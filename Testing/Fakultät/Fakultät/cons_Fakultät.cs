using System;

namespace Fakultät
{
    class cons_Fakultät
    {
        static void Main(string[] args)
        {
            var fakultät = 0;
            var eingabe = 0;
            var ergebnis = 0;
            bool ende = false;

            while (!ende)
            {
		        eingabe = HoleZahleneingabe();
                ergebnis = BerechneFakultät(eingabe, fakultät);

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

        internal static int BerechneFakultät(int eingabe, int fakultät)
        {
            int ergebnis = 1;
            for (int min = 1; min <= eingabe; min++)
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
            if (Console.ReadLine().ToLower() == "j")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
