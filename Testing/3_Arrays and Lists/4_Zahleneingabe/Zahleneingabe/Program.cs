using System;
using System.Collections.Generic;

namespace Zahleneingabe
{
    public class Program
    {
        internal static void Main(string[] args)
        {
            var zahlenListe = ErstelleZahlenListe();
            Ausgabe(zahlenListe);
        }

        internal static List<int> ErstelleZahlenListe()
        {
            Console.WriteLine(@"Geben Sie eine Zahl oder " + '"' +"Ende\" ein!");
            var eingabe = Console.ReadLine().ToLower();
            var zahlenListe = new List<int>();

            while (eingabe != "ende")
            {
                zahlenListe.Add(Convert.ToInt32(eingabe));
                eingabe = Console.ReadLine();   
            }
            return zahlenListe;
        }

        internal static void Ausgabe(List<int> zahlenListe)
        {
            Console.WriteLine(string.Join(", ", zahlenListe));
        }
    }
}
