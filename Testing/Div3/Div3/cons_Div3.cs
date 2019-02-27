using System;

namespace Div3
{
    class cons_Div3
    {
        static void Main(string[] args)
        {
            bool ende = false;
            int zähler = 0;

            ZeigeÜberschrift();

            while(!ende)
            {
                double anfangswert = HoleZahlenEingabe();
                double obergrenze = HoleZahlenEingabe();
                double ergebnis = Berechne(zähler, anfangswert, obergrenze);
                ZeigeErgebnis(ergebnis);
                ende = FrageObEnde();
            }
        }

        private static void ZeigeÜberschrift()
        {
            Console.WriteLine("\nZähler - Division durch Drei\n\n");
        }

        private static double HoleZahlenEingabe()
        {
            Console.WriteLine("Bitte geben Sie Ihre Zahl ein!");
            var eingabe = Console.ReadLine();
            return Convert.ToInt32(eingabe);
        }

        internal static int Berechne(int zähler, double anfangswert, double obergrenze)
        {
            while (anfangswert <= obergrenze)
            {
                if (anfangswert % 3 == 0)
                {
                    zähler++;
                }
                anfangswert++;
            }
            return zähler;
        }

        private static void ZeigeErgebnis(double ergebnis)
        {
            Console.WriteLine("\nDas Ergebnis der Zählung ist {0}.", ergebnis);
        }

        private static bool FrageObEnde()
        {
            Console.WriteLine("\nMöchten Sie noch einmal zählen lassen? <j/n>");
            if (Console.ReadLine().ToLower() == "j")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
