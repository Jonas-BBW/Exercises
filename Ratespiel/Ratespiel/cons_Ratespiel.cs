using System;

namespace Ratespiel
{
    class cons_Ratespiel
    {
        static void Main(string[] args)
        {
            int zufallszahl = GeneriereZufallszahl();
            PrüfeEingabe(zufallszahl);
        }

        private static int GeneriereZufallszahl()
        {
            Random zufall = new Random();
            int zufallszahl = zufall.Next(1, 11);
            return zufallszahl;
        }

        private static int ErfrageZahl()
        {
            Console.WriteLine("Versuchen Sie die Zufallszahl zu erraten! (1-10)");
            return Convert.ToInt16(Console.ReadLine());
        }

        private static void PrüfeEingabe(int zufallszahl)
        {
            var zähler = 0;
            while (true)
            {
                var eingabe = ErfrageZahl();
                if (zufallszahl == eingabe && zähler <= 2)
                {
                    Console.WriteLine("Herzlichen Glückwunsch! Sie haben gewonnen.");
                    Console.WriteLine("\nDrücken Sie Enter um das Programm zu beenden!");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                else if (zähler > 2)
                {
                    Console.WriteLine("Sie haben verloren.");
                    Console.WriteLine("\nDrücken Sie Enter um das Programm zu beenden!");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Das war leider falsch.");
                }
                zähler++;
            }
        }
    }
}
