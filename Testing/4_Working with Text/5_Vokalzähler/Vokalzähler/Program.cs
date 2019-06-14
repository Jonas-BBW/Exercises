using System.Linq;
using System;

namespace Vokalzähler
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            var wort = HoleWort();
            var ergebnis = WortVerarbeitung(wort);
            Ausgabe(ergebnis);
        }
        private static string HoleWort()
        {
            Console.WriteLine("Geben Sie eine deutsches Wort ein!");
            return Console.ReadLine().Replace("ä", "ae").Replace("ö", "oe").Replace("ü", "ue");
        }
        internal static int WortVerarbeitung(string wort)
        {
            var vokale = new []{'a', 'e', 'i', 'o', 'u'};
            var zähler = 0;
            foreach (var buchstabe in wort)
            {
                if (vokale.Contains(buchstabe))
                    zähler++;
            }
            return zähler;
        }
        private static void Ausgabe(int ergebnis)
        {
            Console.WriteLine("Anzahl der Vokale: " + ergebnis);
        }
    }
}