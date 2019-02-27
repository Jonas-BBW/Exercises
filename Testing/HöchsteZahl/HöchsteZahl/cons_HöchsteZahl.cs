using System;
using System.Collections.Generic;
using System.Linq;

namespace HöchsteZahl
{
    class cons_HöchsteZahl
    {
        static void Main(string[] args)
        {
            var eingabe = HoleZahlenEingabe();
            var maxzahl = ErkenneZahl(eingabe);
            ZeigeZahl(maxzahl);
        }

        private static List<int> HoleZahlenEingabe()
        {
            Console.WriteLine("Geben Sie die Zahlen nur durch ein Komma getrennt ein! (z.B. 5,3,8,1,4)");
            var eingabeListe = Console.ReadLine().Split(',').ToList();
            var ausgabeListe = new List<int>();
            foreach (var zeilen in eingabeListe)
            {
                ausgabeListe.Add(Convert.ToInt32(zeilen));
            }
            return ausgabeListe;
        }

        internal static int ErkenneZahl(List<int> eingabe)
        {
            var maxzahl = eingabe.Max();
            return maxzahl;
        }

        private static void ZeigeZahl(int maxzahl)
        {
            Console.WriteLine("\nDie größte Zahl ist {0}.\n", maxzahl);
            Console.WriteLine("\nDrücken Sie Enter um zu beenden!", maxzahl);
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}
