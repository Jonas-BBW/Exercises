using System;
using System.Collections.Generic;
using System.Linq;

namespace SechsAusNeunundvierzig
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            //var ziehungDatenfeld = Ziehung();
            //Console.WriteLine(string.Join(",", ziehungDatenfeld));
            var eingabeDatenfeld = Tippabgabe();
            var ziehungDatenfeld = Ziehung();
            var ergebnis = Vergleich(eingabeDatenfeld, ziehungDatenfeld);
            Ausgabe(ergebnis);
        }
        private static int[] Tippabgabe()
        {
            Console.WriteLine("Geben Sie Ihren Tipp ab! (1,2,3,4,5,6)\r\nDie Zahlen dürfen nicht doppelt vorkommen.");
            return Console.ReadLine().Split(',').ToList().ConvertAll(int.Parse).ToArray();
        }
        internal static int[] Ziehung()
        {
            return Enumerable.Range(1, 49).OrderBy(nummer => Guid.NewGuid()).Take(6).ToArray();
        }
        internal static int Vergleich(int[] eingabeDatenfeld, int[] ziehungDatenfeld)
        {
            var richtigeListe = new List<int>();
            if (eingabeDatenfeld == ziehungDatenfeld)
                return 6;
            if (eingabeDatenfeld[0] == ziehungDatenfeld[0])
                richtigeListe.Add(1);

            if (eingabeDatenfeld[1] == ziehungDatenfeld[1])
                richtigeListe.Add(1);

            if (eingabeDatenfeld[2] == ziehungDatenfeld[2])
                richtigeListe.Add(1);

            if (eingabeDatenfeld[3] == ziehungDatenfeld[3])
                richtigeListe.Add(1);

            if (eingabeDatenfeld[4] == ziehungDatenfeld[4])
                richtigeListe.Add(1);

            if (eingabeDatenfeld[5] == ziehungDatenfeld[5])
                richtigeListe.Add(1);
            return richtigeListe.Sum();
        }
        private static void Ausgabe(int ergebnis)
        {
            switch (ergebnis)
            {
                case 6: Console.WriteLine("Herzlichen Glückwunsch, Sie haben 6 richtige!!!"); break;
                default: Console.WriteLine("Sie haben {0} richtige.", ergebnis); break;
            }
        }
    }
}