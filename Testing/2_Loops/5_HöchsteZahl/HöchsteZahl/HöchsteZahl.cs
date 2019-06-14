using System;
using System.Collections.Generic;
using System.Linq;

namespace HöchsteZahl
{
    public class HöchsteZahl
    {
        public static void Main(string[] args)
        {
            var eingabe = HoleZahlenEingabe();
            var höchsteZahl = ErkenneZahl(eingabe);
            ZeigeZahl(höchsteZahl);
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
            return eingabe.Max();
        }

        private static void ZeigeZahl(int höchsteZahl)
        {
            Console.WriteLine("\nDie größte Zahl ist {0}.\n", höchsteZahl);
        }
    }
}