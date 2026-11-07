using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace ExcelAutomation
{
    internal sealed record ParsedEquationSystem(
        double[,] Coefficients,
        double[] Constants
    );

    internal sealed class EquationParseException : Exception
    {
        public EquationParseException(int equation, string message)
            : base($"Рівняння {equation}: {message}")
        {
        }
    }

    internal static class EquationParser
    {
        // Граматика одного математичного члена.
        private const string TermPattern =
            @"(?<number>(?:\d+(?:[.,]\d+)?|[.,]\d+))?" +
            @"(?<parameter>[ab])?" +
            @"(?<variable>x[123])?";

        private static readonly Regex TermRegex = new(
            TermPattern,
            RegexOptions.Compiled | RegexOptions.CultureInvariant
        );

        // Правило перевірки: повідомлення та предикат.
        private sealed record ValidationRule(
            string Error,
            Func<string, bool> Check
        );

        // Послідовність незалежних перевірок рівняння.
        private static readonly ValidationRule[] Rules =
        [
            // 1. Забороняємо порожній рядок.
            new(
                "Порожнє рівняння.",
                text => !string.IsNullOrWhiteSpace(text)
            ),

            // 2. Вимагаємо рівно один знак рівності.
            new(
                "Рівняння повинно містити рівно один знак '='.",
                text => text.Count(c => c == '=') == 1
            ),

            // 3. Перевіряємо наявність обох частин.
            new(
                "Обидві частини рівняння повинні бути заповнені.",
                text => text.Split('=').All(part => part.Length > 0)
            ),

            // 4. Перевіряємо допустимий набір символів.
            new(
                "Виявлено недопустимий символ.",
                text => Regex.IsMatch(text, @"^[0-9xab+\-=.,]+$")
            ),

            // 5. Перевірка індексів змінних.
            new(
                "Допускаються лише змінні x1, x2, x3.",
                text => !Regex.IsMatch(
                    text,
                    @"x[04-9]|x[123]\d+"
                )
            ),

            // 6. Заборона послідовних операторів.
            new(
                "Некоректна послідовність операторів.",
                text => !Regex.IsMatch(
                    text,
                    @"[+\-]{2,}"            
                )
            )
        ];

        // 1. Головний метод: перевірка та побудова системи.
        public static ParsedEquationSystem Parse(
            string[] equations,
            double a = 1,
            double b = 1)
        {
            if (equations is not { Length: 3 })
                throw new ArgumentException(
                    "Система повинна містити три рівняння."
                );

            if (!double.IsFinite(a) || !double.IsFinite(b))
                throw new ArgumentException(
                    "Параметри a та b повинні бути скінченними числами."
                );

            double[,] coefficients = new double[3, 3];
            double[] constants = new double[3];

            for (int row = 0; row < 3; row++)
            {
                string equation = Normalize(equations[row]);

                Validate(equation, row + 1);

                string[] sides = equation.Split('=');

                double left = ParseSide(
                    sides[0], row, 1, a, b, coefficients);

                double right = ParseSide(
                    sides[1], row, -1, a, b, coefficients);

                constants[row] = left - right;
            }

            return new ParsedEquationSystem(coefficients, constants);
        }

        // 2. Нормалізація запису рівняння.
        private static string Normalize(string? equation)
        {
            return Regex.Replace(equation ?? "", @"\s+", "")
                .Replace('−', '-')
                .ToLowerInvariant();
        }

        // 3. Послідовне застосування правил валідації.
        private static void Validate(string equation, int number)
        {
            foreach (ValidationRule rule in Rules)
            {
                if (rule.Check(equation))
                    continue;

                throw new EquationParseException(number, rule.Error);
            }
        }

        // 4. Розбір однієї частини рівняння.
        private static double ParseSide(
            string side,
            int row,
            int direction,
            double a,
            double b,
            double[,] coefficients)
        {
            double constant = 0;
            int position = 0;

            while (position < side.Length)
            {
                // Визначення знака поточного члена.
                int sign = 1;

                if (side[position] is '+' or '-')
                {
                    sign = side[position] == '-' ? -1 : 1;
                    position++;
                }

                if (position >= side.Length)
                    throw new EquationParseException(
                        row + 1, "Відсутній член після знака операції.");

                // Розпізнавання математичного члена.
                Match match = TermRegex.Match(side, position);

                if (!match.Success ||
                    match.Index != position ||
                    match.Length == 0)
                {
                    throw new EquationParseException(
                        row + 1,
                        $"Неочікуваний символ у позиції {position + 1}."
                    );
                }

                string number = match.Groups["number"].Value;
                string parameter = match.Groups["parameter"].Value;
                string variable = match.Groups["variable"].Value;

                // Числовий коефіцієнт.
                double value = number.Length == 0
                    ? 1
                    : double.Parse(
                        number.Replace(',', '.'),
                        CultureInfo.InvariantCulture);

                // Параметричний множник.
                value *= parameter switch
                {
                    "a" => a,
                    "b" => b,
                    "" => 1,
                    _ => throw new FormatException(
                        $"Невідомий параметр: {parameter}")
                };

                value *= sign * direction;

                if (!double.IsFinite(value))
                    throw new EquationParseException(
                        row + 1, "Некоректний числовий коефіцієнт.");

                // Визначення типу члена.
                switch (variable)
                {
                    case "x1":
                        coefficients[row, 0] += value;
                        break;

                    case "x2":
                        coefficients[row, 1] += value;
                        break;

                    case "x3":
                        coefficients[row, 2] += value;
                        break;

                    case "" when parameter.Length == 0:
                        constant += value;
                        break;

                    default:
                        throw new EquationParseException(
                            row + 1,
                            "Параметр повинен бути коефіцієнтом змінної.");
                }

                position += match.Length;

                // Контроль роздільника між членами.
                if (position < side.Length &&
                    side[position] is not ('+' or '-'))
                {
                    throw new EquationParseException(
                        row + 1,
                        $"Неочікуваний символ '{side[position]}' " +
                        $"у позиції {position + 1}."
                    );
                }
            }

            return constant;
        }

        // 5. Діагностичне представлення матриці та вектора.
        public static string FormatDiagnostics(ParsedEquationSystem system)
        {
            StringBuilder result = new();

            result.AppendLine("Матриця коефіцієнтів A:");
            result.AppendLine();

            for (int row = 0; row < 3; row++)
            {
                result.AppendLine(string.Join("    ",
                    Enumerable.Range(0, 3)
                        .Select(column =>
                            system.Coefficients[row, column]
                                .ToString("0.####", CultureInfo.InvariantCulture))));
            }

            result.AppendLine();
            result.AppendLine("Вектор вільних членів B:");
            result.AppendLine();

            foreach (double value in system.Constants)
                result.AppendLine(value.ToString("0.####", CultureInfo.InvariantCulture));

            return result.ToString();
        }

        // Пошук параметрів у порядку їх появи.
        public static List<char> FindParameters(string[] equations)
        {
            List<char> parameters = [];

            foreach (string equation in equations)
            {
                string normalized = Normalize(equation);

                foreach (Match match in Regex.Matches(
                    normalized,
                    @"[ab](?=x[123])"))
                {
                    char parameter = match.Value[0];

                    if (!parameters.Contains(parameter))
                        parameters.Add(parameter);
                }
            }

            return parameters;
        }
    }
}


