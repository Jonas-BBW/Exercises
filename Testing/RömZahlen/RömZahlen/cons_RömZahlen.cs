using System;
using System.Collections.Generic;
using System.Linq;

namespace RömZahlen
{
    class cons_RömZahlen
    {
        static void Main(string[] args)
        {
            var Steuerung = new Steuerung();
            Steuerung.Vorgänge();
        }

        public class Steuerung
        {
            public void Vorgänge()
            {
                var manipulation = new Manipulation();
                var eingabeListe = EingabeAusgabe.Eingabe();
                var übersetzung = manipulation.Übersetzung(eingabeListe);
                EingabeAusgabe.Ausgabe(übersetzung);
            }
        }

        public class EingabeAusgabe
        {
            public EingabeAusgabe() { }

            public static List<char> Eingabe()
            {
                Console.WriteLine("Geben Sie eine römische Zahl ein!");
                var eingabeListe = Console.ReadLine().ToCharArray().ToList();
                return eingabeListe;
            }

            public static void Ausgabe(int eingabe)
            {
                Console.WriteLine("\nDie zugehörige Dezimalzahl ist {0}.\n", eingabe);
                Console.WriteLine("\nDrücken Sie Enter um zu beenden!");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }

        public class Manipulation
        {
            private Dictionary<char, int> übersetzungDict;

            public Manipulation()
            {
                übersetzungDict = new Dictionary<char, int>();
                übersetzungDict.Add('I', 1);
                übersetzungDict.Add('V', 5);
                übersetzungDict.Add('X', 10);
                übersetzungDict.Add('L', 50);
                übersetzungDict.Add('C', 100);
                übersetzungDict.Add('D', 500);
                übersetzungDict.Add('M', 1000);
            }

            public int Übersetzung(List<char> eingabeListe)
            {
                var länge = eingabeListe.Count;
                var counter = 0;
                var ausgabe = 0;

                do
                {
                    if (counter + 1 < länge)
                    {
                        int vorherigeZahl = übersetzungDict[eingabeListe[counter]];
                        int nächsteZahl = übersetzungDict[eingabeListe[counter + 1]];
                        if (vorherigeZahl < nächsteZahl)
                        {
                            ausgabe = ausgabe + nächsteZahl - vorherigeZahl;
                        }
                        else if (vorherigeZahl >= nächsteZahl)
                        {
                            ausgabe = ausgabe + nächsteZahl + vorherigeZahl;
                        }
                        counter = counter + 2;
                    }
                }
                while (counter < länge);
                return ausgabe;
            }
        }
    }
}
