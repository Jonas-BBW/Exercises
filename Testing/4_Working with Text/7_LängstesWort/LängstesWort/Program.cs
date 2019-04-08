using System;
using System.IO;
using System.Linq;

namespace LängstesWort
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            var längstesWort = HoleLängstesWort();
            Ausgabe(längstesWort);
        }
        internal static string HoleLängstesWort()
        {
            const string dateiname = "längstesWort.txt";
            var verzeichnis = AppDomain.CurrentDomain.BaseDirectory;
            var inhalt = File.ReadAllText(verzeichnis + dateiname);
            return inhalt.Split(' ').ToList().OrderBy(s => s.Length).Last();
        }
        private static void Ausgabe(string längstesWort)
        {
            Console.WriteLine("Das längste Wort ist \"{0}\".",längstesWort);
        }
    }
}