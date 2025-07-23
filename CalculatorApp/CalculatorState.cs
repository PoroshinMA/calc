using System.IO;

namespace CalculatorApp
{
    public static class CalculatorState
    {
        public static void Save(string file, string value)
        {
            File.WriteAllText(file, value);
        }

        public static string Load(string file)
        {
            return File.Exists(file) ? File.ReadAllText(file) : null;
        }
    }
} 