
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelAutomation
{
    internal static class ExcelEquationSolver
    {
        // 1. Розв'язання системи через Microsoft Excel.
        public static double[] Solve(ParsedEquationSystem system)
        {
            double[,] A = system.Coefficients;
            double[] B = system.Constants;

            // Формування вектора-стовпця для Excel.
            double[,] vector =
            {
                { B[0] },
                { B[1] },
                { B[2] }
            };

            Excel.Application? excel = null;

            try
            {
                // 2. Створення екземпляра Microsoft Excel.
                excel = new Excel.Application();

                // 3. Перевірка визначника матриці.
                double determinant =
                    excel.WorksheetFunction.MDeterm(A);

                if (Math.Abs(determinant) < 1e-10)
                {
                    throw new InvalidOperationException(
                        "Система не має єдиного розв'язку."
                    );
                }

                // 4. Обчислення оберненої матриці.
                object inverse =
                    excel.WorksheetFunction.MInverse(A);

                // 5. Множення оберненої матриці на вектор B.
                object result =
                    excel.WorksheetFunction.MMult(inverse, vector);

                // 6. Перетворення результату Excel у масив C#.
                Array values = (Array)result;

                int row = values.GetLowerBound(0);
                int column = values.GetLowerBound(1);

                return
                [
                    Convert.ToDouble(
                        values.GetValue(row, column)),

                    Convert.ToDouble(
                        values.GetValue(row + 1, column)),

                    Convert.ToDouble(
                        values.GetValue(row + 2, column))
                ];
            }
            finally
            {
                // 7. Завершення Excel та звільнення COM-об'єкта.
                if (excel != null)
                {
                    try
                    {
                        excel.Quit();
                    }
                    finally
                    {
                        Marshal.FinalReleaseComObject(excel);
                    }
                }
            }
        }

        // 8. Перевірка розв'язку підстановкою в систему.
        public static bool Verify(
            ParsedEquationSystem system,
            double[] x)
        {
            const double tolerance = 1e-8;

            double[,] A = system.Coefficients;
            double[] B = system.Constants;

            for (int row = 0; row < 3; row++)
            {
                double sum = 0;

                for (int column = 0; column < 3; column++)
                {
                    sum += A[row, column] * x[column];
                }

                if (Math.Abs(sum - B[row]) > tolerance)
                    return false;
            }

            return true;
        }
    }
}

