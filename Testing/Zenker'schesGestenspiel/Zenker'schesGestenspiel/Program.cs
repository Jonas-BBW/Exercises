using System;

namespace ZenkerschesGestenspiel
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            var spielerWahl = SpielerWahl();
            var gegnerischeWahl = GegnerischeWahl();
            var ergebnis = GestenVergleichen(spielerWahl, gegnerischeWahl);
            Ausgabe(ergebnis, spielerWahl, gegnerischeWahl);
        }
        internal static int GegnerischeWahl()
        {
            var zufall = new Random();
            return zufall.Next(1, 5);
        }
        internal static int SpielerWahl()
        {
            Console.WriteLine("Treffen Sie Ihre Auswahl!");
            Console.WriteLine("1 = Schere; 2 = Stein; 3 = Papier; 4 = Echse; 5 = Spock");
            return Convert.ToInt32(Console.ReadLine());
        }
        internal static string GestenVergleichen(int spielerWahl, int gegnerischeWahl)
        {
            var möglichkeitenArray = new string[5,5]
            {
            {"unentschieden", "Spieler", "Spieler", "Spieler", "Computer"},
            {"Computer", "unentschieden", "Computer", "Spieler", "Computer"},
            {"Computer", "Spieler", "unentschieden", "Computer", "Spieler"},
            {"Computer", "Computer", "Spieler", "unentschieden", "Spieler"},
            {"Spieler", "Spieler", "Computer", "Computer", "unentschieden"}
            };
            return möglichkeitenArray[spielerWahl, gegnerischeWahl];
        }
        internal static void Ausgabe(string ergebnis, int spielerWahl, int gegnerischeWahl)
        {
            switch (ergebnis)
            {
                case "Spieler":       Console.WriteLine("Sie haben gewonnen!"); break;
                case "Computer":      Console.WriteLine("Sie haben verloren."); break;
                case "unentschieden": Console.WriteLine("Unentschieden!");      break;
            }
            if (spielerWahl == 1 && gegnerischeWahl == 3 || spielerWahl == 3 && gegnerischeWahl == 1)
                Console.WriteLine("Schere schneidet Papier");
            else if (spielerWahl == 1 && gegnerischeWahl == 4 || spielerWahl == 4 && gegnerischeWahl == 1)
                Console.WriteLine("Schere köpft Echse");
            else if (spielerWahl == 2 && gegnerischeWahl == 1 || spielerWahl == 1 && gegnerischeWahl == 2)
                Console.WriteLine("Stein schleift Schere");
            else if (spielerWahl == 2 && gegnerischeWahl == 4 || spielerWahl == 4 && gegnerischeWahl == 2)
                Console.WriteLine("Stein zerquetscht Echse");
            else if (spielerWahl == 3 && gegnerischeWahl == 2 || spielerWahl == 2 && gegnerischeWahl == 3)
                Console.WriteLine("Papier bedeckt Stein");
            else if (spielerWahl == 3 && gegnerischeWahl == 5 || spielerWahl == 5 && gegnerischeWahl == 3)
                Console.WriteLine("Papier widerlegt Spock");
            else if (spielerWahl == 4 && gegnerischeWahl == 3 || spielerWahl == 3 && gegnerischeWahl == 4)
                Console.WriteLine("Echse frisst Papier");
            else if (spielerWahl == 4 && gegnerischeWahl == 5 || spielerWahl == 5 && gegnerischeWahl == 4)
                Console.WriteLine("Echse vergiftet Spock");
            else if (spielerWahl == 5 && gegnerischeWahl == 1 || spielerWahl == 1 && gegnerischeWahl == 5)
                Console.WriteLine("Spock zertrümmert Schere");
            else if (spielerWahl == 5 && gegnerischeWahl == 2 || spielerWahl == 2 && gegnerischeWahl == 5)
                Console.WriteLine("Spock verdampft Stein");
        }
    }
}