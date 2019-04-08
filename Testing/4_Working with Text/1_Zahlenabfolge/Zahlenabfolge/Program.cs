using System;
using System.Collections.Generic;
using System.Linq;

namespace Zahlenabfolge
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var eingabeListe = EingabeListe();
            var abfolge = VergleicheZahlen(eingabeListe);
            Ausgabe(abfolge);
        }
        private static List<int> EingabeListe()
        {
            Console.WriteLine("Bitte geben Sie eine von Bindestrichen getrennte Zahlenfolge ein!");
            return Console.ReadLine().Split('-').ToList().ConvertAll(int.Parse);
        }
        internal static bool VergleicheZahlen(List<int> eingabeListe)
        {
            var abfolge = false;

            for (var iteration = 0; iteration < eingabeListe.Count - 1; iteration++)
            {
                if (eingabeListe[iteration] + 1 == eingabeListe[iteration + 1] || eingabeListe[iteration] - 1 == eingabeListe[iteration + 1])
                    abfolge = true;
                else
                {
                    abfolge = false;
                    break;
                }
            }
            return abfolge;
        }
        private static void Ausgabe(bool abfolge)
        {
            Console.WriteLine(abfolge ? "Es ist eine direkte Abfolge von Zahlen." : "Es ist keine direkte Abfolge von Zahlen.");
        }
    }
}
