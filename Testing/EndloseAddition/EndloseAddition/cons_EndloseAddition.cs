using System;

namespace cons_EndloseAddition
{
    class cons_EndloseAddition
    {
        static void Main(string[] args)
        {
            var ende = false;
            var ergebnis = 0.0;
            var eingabe = " ";

            while (!ende)
            {
                eingabe = HoleEingabe();
                ende = PrüfeObEnde(eingabe);
                if (!ende)
                {
                    ergebnis = ErgebnisBerechnung(eingabe, ergebnis);
                }
            }

            ZeigeErgebnis(ergebnis);
        }
    

        private static string HoleEingabe()
        {
            Console.WriteLine("Geben Sie eine Zahl oder \"ende\" - ohne Anführungsstriche - ein!");
            return Console.ReadLine();
        }

        private static bool PrüfeObEnde(string eingabe)
        {
            if (eingabe.ToLower() == "ende")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal static double ErgebnisBerechnung(string eingabe, double ergebnis)
        {
            return ergebnis + Convert.ToDouble(eingabe);
        }

        private static void ZeigeErgebnis(double ergebnis)
        {
            Console.WriteLine("\nDas Ergebnis lautet {0}.", ergebnis);
            Console.WriteLine("\nDrücken Sie Enter um das Programm zu beenden!");
            Console.ReadLine();
        }
    }
}
