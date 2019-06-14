using System;

namespace Ratespiel
{
    public class Ratespiel
    {
        public static void Main(string[] args)
        {
            var zufallszahl = GeneriereZufallszahl();
            var ergebnis = Spiel(zufallszahl);
            Ausgabe(ergebnis);

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

        public static string Spiel(int zufallszahl)
        {
            for (var iteration = 0; iteration < 4; iteration++)
            {
                var eingabe = ErfrageZahl(zufallszahl);
                if (zufallszahl == eingabe)
                    return "gewonnen";
            }
            return "verloren";
        }

        public static void Ausgabe(string ergebnis)
        {
            if (ergebnis == "gewonnen")
                Console.WriteLine("Sie haben gewonnen!\r\nHerzlichen Glückwunsch!");
            else if (ergebnis == "verloren")
                Console.WriteLine("Sie haben verloren... Schade!");
        }
    }
}