using System;
using System.Collections.Generic;

namespace RitschRatsch
{
    class cons_RitschRatsch
    {
        static void Main(string[] args)
        {
            int untergrenze = new BenutzerInteraktion().HoleUntergrenze();
            int obergrenze = new BenutzerInteraktion().HoleObergrenze();
            List<string> ergebnis = new Problemlösung().Berechnung(untergrenze, obergrenze);
            new BenutzerInteraktion().Ausgabe(ergebnis);
        }

        public class BenutzerInteraktion
        {
            public BenutzerInteraktion()
            {

            }

            internal int HoleUntergrenze()
            {
                Console.WriteLine("Geben Sie die Untergrenze an!");
                if (Convert.ToInt32(Console.ReadLine()) == 0)
                    return 1;
                return Convert.ToInt32(Console.ReadLine());
            }

            internal int HoleObergrenze()
            {
                Console.WriteLine("Geben Sie die die Obergrenze an!");
                return Convert.ToInt32(Console.ReadLine());
            }

            internal void Ausgabe(List<string> ausgabeListe)
            {
                Console.WriteLine("\n");
                foreach (var zeile in ausgabeListe)
                {
                    Console.WriteLine(zeile.ToString());
                }
                Console.ReadLine();
            }
        }

        public class Problemlösung
        {
            internal Problemlösung()
            {

            }

            internal List<string> Berechnung(int untergrenze, int obergrenze)
            {
                List<string> ausgabeListe = new List<string>();

                do
                {
                    if (untergrenze <= obergrenze)
                    {
                        if (untergrenze % 3 == 0 && untergrenze % 5 == 0)
                        {
                            ausgabeListe.Add("RitschRatsch");
                        }
                        else if (untergrenze % 3 == 0)
                        {
                            ausgabeListe.Add("Ritsch");
                        }
                        else if (untergrenze % 5 == 0)
                        {
                            ausgabeListe.Add("Ratsch");
                        }
                        else
                        {
                            ausgabeListe.Add(untergrenze.ToString());
                        }
                        untergrenze++;
                    }
                }
                while (untergrenze != obergrenze);
                return ausgabeListe;
            }
        }
    }
}