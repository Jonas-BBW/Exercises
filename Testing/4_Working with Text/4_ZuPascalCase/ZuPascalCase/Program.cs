using System;
using System.Globalization;

namespace ZuPascalCase
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            var eingabe = EingabeHolen();
            var pascalCase = EingabeVerarbeiten(eingabe);
            Ausgabe(pascalCase);
        }
        private static string EingabeHolen()
        {
            Console.WriteLine("Geben Sie die Worte an, die zu PascalCase konvertiert werden sollen!");
            return Console.ReadLine().ToLower();
        }
        internal static string EingabeVerarbeiten(string eingabe)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(eingabe).Replace(" ", "");
        }

        private static void Ausgabe(string pascalCase)
        {
            Console.WriteLine(pascalCase);
        }
    }
}