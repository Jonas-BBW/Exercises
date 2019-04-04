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
                var ergebnis = 0;
                var gültigeZahl = int.TryParse(eingabe, out ergebnis);

                if (gültigeZahl)
                {
                    if (zahlen.Contains(ergebnis))
                    {
                        Console.WriteLine(ergebnis + " gibt es bereits.\r\nVersuchen Sie es erneut!");
                        iteration--;
                    }
                    else
                    {
                        zahlen[iteration] = ergebnis;
                    }
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe!");
                    iteration--;
                }
            }
            return zahlen;
        }
        internal static void Ausgabe(int[] zahlenArray)
        {
            var zahlenListeSortiert = zahlenArray.ToList().OrderBy(p => p).ToList();
            foreach (var zahl in zahlenListeSortiert)
            {
                Console.Write(zahl);
            }
            Console.WriteLine();
        }
    }
}