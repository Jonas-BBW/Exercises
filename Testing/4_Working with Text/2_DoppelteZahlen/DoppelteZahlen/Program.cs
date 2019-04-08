using System;
using System.Collections.Generic;
using System.Linq;

namespace DoppelteZahlen
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            var eingabeListe = EingabeListe();
            var listeDoppelterEinträge = HoleDoppelteEinträge(eingabeListe);
            Ausgabe(listeDoppelterEinträge);
        }
        private static List<int> EingabeListe()
        {
            Console.WriteLine("Bitte geben Sie eine mit Bindestrichen getrennte Liste von Zahlen ein!");
            return Console.ReadLine().Split('-').ToList().ConvertAll(Convert.ToInt32);
        }
        internal static List<int> HoleDoppelteEinträge(List<int> eingabeListe)
        {
            var listeDoppelterEinträge = new List<int>();
            eingabeListe = eingabeListe.OrderBy(a => a).ToList();
            Console.WriteLine("Duplikate:");
            for (var iteration = 0; iteration < eingabeListe.Count - 1; iteration++)
            {
                if(eingabeListe[iteration] == eingabeListe[iteration + 1])
                    listeDoppelterEinträge.Add(eingabeListe[iteration]);
            }
            return listeDoppelterEinträge;
        }
        private static void Ausgabe(List<int> listeDoppelterEinträge)
        {
            Console.WriteLine(string.Join(", ", listeDoppelterEinträge));
        }
    }
}
