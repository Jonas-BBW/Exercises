using System;

namespace Ratespiel
{
    class Ratespiel
    {
        public static void Main(string[] args)
        {
            var zufallszahl = GeneriereZufallszahl();
            for(var iteration = 0; iteration<4; iteration++)
            {
                var eingabe = ErfrageZahl(zufallszahl);
                var ergebnis = PrüfeEingabe(zufallszahl, eingabe);
                if (ergebnis)
                {
                    AusgabeSieg();
                }
            }
            AusgabeNiederlage();
        }
        internal static int GeneriereZufallszahl()
        {
            var zufall = new Random();
            var zufallszahl = zufall.Next(1, 11);
            return zufallszahl;
        }
        private static int ErfrageZahl(int zufallszahl)
        {
            //Console.WriteLine(zufallszahl);
            Console.WriteLine("Versuchen Sie die Zufallszahl zu erraten! (1-10)");
            return Convert.ToInt16(Console.ReadLine());
        }
        internal static bool PrüfeEingabe(int zufallszahl, int eingabe)
        {
            return zufallszahl == eingabe;
        }
        private static void AusgabeSieg()
        {
            Console.WriteLine("Sie haben gewonnen!");
            Console.WriteLine("\nDrücken Sie Enter um das Programm zu beenden!");
            Console.ReadLine();
            Environment.Exit(0);
        }
        private static void AusgabeNiederlage()
        {
            Console.WriteLine("Sie haben verloren.");
            Console.WriteLine("\nDrücken Sie Enter um das Programm zu beenden!");
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}