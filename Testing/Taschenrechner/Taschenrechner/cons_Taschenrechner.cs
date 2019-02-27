using System;

namespace Taschenrechner
{
    class cons_Taschenrechner
    {
        static void Main(string[] args)
        {
            var ende = false;
            var rechenart = ' ';
            var zahl1 = 0.0;
            var zahl2 = 0.0;
            var ergebnis = 0.0;

            ZeigeÜberschrift();
            do
            {
                zahl1 = HoleZahlenEingabe();
                rechenart = HoleRechenart();
                zahl2 = HoleZahlenEingabe();
                ergebnis = Berechne(zahl1, zahl2, rechenart);
                ZeigeErgebnis(zahl1, zahl2, rechenart, ergebnis);
                ende = FrageObEnde();
            }
            while (!ende);
        }

        private static void ZeigeÜberschrift()
        {
            Console.WriteLine();
            Console.WriteLine("\tTaschenrechner\n");
            Console.WriteLine("===============================");
        }

        private static char HoleRechenart()
        {
            Console.WriteLine("\nBitte geben Sie eine Rechenart ein! (+,-,*,:)");
            return Convert.ToChar(Console.ReadLine());
        }

        private static double HoleZahlenEingabe()
        {
            Console.WriteLine("\nBitte geben Sie eine Zahl ein.");
            var eingabe = Console.ReadLine();
            return Convert.ToDouble(eingabe);
        }

        internal static double Berechne(double zahl1, double zahl2, char rechenart)
        {
            switch (rechenart)
            {
                case '+':
                    return zahl1 + zahl2;
                case '-':
                    return zahl1 - zahl2;
                case '*':
                    return zahl1 * zahl2;
                case ':':
                    return zahl1 / zahl2;
                default:
                    Console.WriteLine("\nDas ist eine falsche Rechenart!\n");
                    return 0;
            }
        }

        private static void ZeigeErgebnis(double zahl1, double zahl2, char rechenart, double ergebnis)
        {
            Console.WriteLine("\nDas Ergebnis von {0}{1}{2} ist {3}", zahl1, rechenart, zahl2, ergebnis);
        }

        private static bool FrageObEnde()
        {
            Console.WriteLine("\nMöchten Sie noch einmal rechnen? <j/n>");
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