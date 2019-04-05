using System;

namespace Bildformat
{
    public class Bildformat
    {
        internal static void Main(string[] args)
        {
            var x = X();
            var y = Y();
            var ergebnis = Vergleichen(x, y);
            Ausgabe(ergebnis);
        }
        internal static int X()
        {
            Console.WriteLine("Bitte geben sie einen Wert für X an!");
            return Convert.ToInt32(Console.ReadLine());
        }
        internal static int Y()
        {
            Console.WriteLine("Bitte geben sie einen Wert für Y an!");
            return Convert.ToInt32(Console.ReadLine());
        }

        internal static string Vergleichen(int x, int y)
        {
            return x > y ? "Querformat" : "Hochformat";
        }

        internal static void Ausgabe(string ergebnis)
        {
            Console.WriteLine("Bildformat: {0}", ergebnis);
        }
    }
}