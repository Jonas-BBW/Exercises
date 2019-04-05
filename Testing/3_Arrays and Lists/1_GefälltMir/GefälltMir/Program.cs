using System;
using System.Collections.Generic;

namespace GefälltMir
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var namenListe = NamenListe();
            Ausgabe(namenListe);
        }
        private static List<string> NamenListe()
        {
            Console.WriteLine("Bitte geben Sie eine beliebige Anzahl von Namen an!");
            while (true)
            {
                var weiter = true;
                var namenListe = new List<string>();

                while (weiter)
                {
                    var eingabe = Console.ReadLine();
                    if (eingabe == "")
                        weiter = false;
                    else
                        namenListe.Add(eingabe);
                }
                return namenListe;
            }
        }
        public static void Ausgabe(List<string> namenListe)
        {
            switch (namenListe.Count)
            {
                case 1: Console.WriteLine(namenListe[0] + " mag deinen Beitrag."); break;
                case 2: Console.WriteLine(namenListe[0] + " und " + namenListe[1] + " mögen deinen Beitrag."); break;
                default: Console.WriteLine(namenListe[0] + ", " + namenListe[1] + " und " + (namenListe.Count - 2) + " Weitere mögen deinen Beitrag."); break;
            }
        }
    }
}