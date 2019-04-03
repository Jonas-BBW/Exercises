using System;

namespace Fakultät
{
    public class Fakultät
    {
        private static void Main(string[] args)
        {
            var ende = false;

            while (!ende)
            {
                var eingabe = HoleZahleneingabe();
                var ergebnis = BerechneFakultät(eingabe);

                ZeigeErgebnis(eingabe, ergebnis);
                ende = FrageObEnde();
            }
        }
        private static int HoleZahleneingabe()
        {
            Console.WriteLine("Von welcher Zahl soll die Fakultät angegeben werden?");
            var eingabe = Console.ReadLine();
            return Convert.ToInt32(eingabe);
        }
        internal static int BerechneFakultät(int eingabe)
        {
            var ergebnis = 1;
            for (var min = 1; min <= eingabe; min++)
            {
                ergebnis *= min;
            }
            return ergebnis;
        }
        private static void ZeigeErgebnis(int eingabe, int ergebnis)
        {
            Console.WriteLine("!{0}={1}", eingabe, ergebnis);
        }
        private static bool FrageObEnde()
        {
            Console.WriteLine("Möchten Sie beenden? <j/n>");
            return Console.ReadLine()?.ToLower() == "j";
        }
    }
}