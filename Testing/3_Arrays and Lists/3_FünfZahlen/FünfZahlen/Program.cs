using System;
using System.Linq;

namespace FünfZahlen
{
    public class Program
    {
        internal static void Main(string[] args)
        {
            var zahlenArray = ErfrageZahlen();
            Ausgabe(zahlenArray);
        }
        internal static int[] ErfrageZahlen()
        {
            var zahlen = new int[5];

            Console.WriteLine("Geben Sie fünf unterschiedliche Zahlen ein!");

            for (var iteration = 0; iteration < 5; iteration++)
            {
                var eingabe = Console.ReadLine();

                if (!PrüfeObGültig(eingabe, zahlen))
                {
                    Fehler();
                    iteration--;
                }
                else
                    zahlen[iteration] = Convert.ToInt32(eingabe);
            }
            return zahlen;
        }
        public static bool PrüfeObGültig(string eingabe, int[] zahlenArray)
        {
            int ergebnis;
            if (!int.TryParse(eingabe, out ergebnis))
                return false;
            return !zahlenArray.Contains(ergebnis);
        }
        public static void Fehler()
        {
            Console.WriteLine("Ungültige Eingabe!");
        }
        internal static void Ausgabe(int[] zahlenArray)
        {
            var zahlenListeSortiert = zahlenArray.ToList().OrderBy(p => p).ToList();
            Console.WriteLine(string.Join(", ", zahlenListeSortiert));
        }
    }
}