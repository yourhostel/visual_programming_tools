using System.Text.Json;

namespace ExcelAutomation
{
    internal sealed class EquationSystem
    {
        public int Id { get; set; }
        public string[] Equations { get; set; } = [];
    }

    internal sealed class EquationSystemCatalog
    {
        public List<EquationSystem> Systems { get; set; } = [];
    }

    internal static class EquationSystemRepository
    {
        public static List<EquationSystem> Load()
        {
            string path = Path.Combine(
                AppContext.BaseDirectory,
                "data",
                "equation-systems.json"
            );

            string json = File.ReadAllText(path);

            var catalog = JsonSerializer.Deserialize<EquationSystemCatalog>(
                json,
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                }
            );

            if (catalog == null || catalog.Systems.Count == 0)
                throw new InvalidDataException("Список систем порожній.");

            if (catalog.Systems.Any(s =>
                s.Id < 1 ||
                s.Equations == null ||
                s.Equations.Length != 3 ||
                s.Equations.Any(string.IsNullOrWhiteSpace)))
            {
                throw new InvalidDataException(
                    "Некоректна структура систем рівнянь."
                );
            }

            if (catalog.Systems.Select(s => s.Id).Distinct().Count()
                != catalog.Systems.Count)
            {
                throw new InvalidDataException(
                    "Виявлено повторення номерів варіантів."
                );
            }

            return catalog.Systems.OrderBy(s => s.Id).ToList();
        }
    }
}
