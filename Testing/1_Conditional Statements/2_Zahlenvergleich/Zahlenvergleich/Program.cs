using System;

namespace Zahlenvergleich
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var ersteZahl = ErfrageErsteZahl();
            var zweiteZahl = ErfrageZweiteZahl();
            var größereZahl = ErkenneGrößereZahl(ersteZahl, zweiteZahl);
            Ausgabe(größereZahl);
        }
        private static int ErfrageErsteZahl()
        {
            Console.WriteLine("Bitte geben Sie die erste Ganzzahl ein!");
            return Convert.ToInt32(Console.ReadLine());
        }
        private static int ErfrageZweiteZahl()
        {
            Console.WriteLine("Bitte geben Sie die erste Ganzzahl ein!");
            return Convert.ToInt32(Console.ReadLine());
        }
        internal static int ErkenneGrößereZahl(int ersteZahl, int zweiteZahl)
        {
            return ersteZahl >= zweiteZahl ? ersteZahl : zweiteZahl;
        }
        private static void Ausgabe(int größereZahl)
        {
            Console.WriteLine("Die größere Zahl ist " + größereZahl + ".");
        }
    }
}