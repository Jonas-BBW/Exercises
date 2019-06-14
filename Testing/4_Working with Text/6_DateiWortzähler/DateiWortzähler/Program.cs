using System;
using System.IO;
using System.Linq;

namespace DateiWortzähler
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            var wortanzahl = WortZähler();
            Ausgabe(wortanzahl);
        }
        internal static int WortZähler()
        {
            const string dateiname = "WortZähler.txt";
            var verzeichnis = AppDomain.CurrentDomain.BaseDirectory;
            var inhalt = File.ReadAllText(verzeichnis + dateiname);
            return inhalt.Split(' ').ToList().Count;
        }
        private static void Ausgabe(int wortanzahl)
        {
            Console.WriteLine("Die Datei enthält {0} Worte.", wortanzahl);
        }
    }
}