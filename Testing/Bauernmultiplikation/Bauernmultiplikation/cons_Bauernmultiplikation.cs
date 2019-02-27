using System;
using System.Collections.Generic;
using System.Linq;

namespace Bauernmultiplikation
{
    class cons_Bauernmultiplikation
    {
        static void Main(string[] args)
        {
            int x = new BenutzerInteraktion().ErfrageX();
            int y = new BenutzerInteraktion().ErfrageY();
            List<int> listeX = new Manipulation().ListeX(x);
            List<int> listeY = new Manipulation().ListeY(x, y);
            int ergebnis = new Manipulation().ErgebnisBerechnung(listeX, listeY);
            new BenutzerInteraktion().Ausgabe(x, y, listeX, listeY, ergebnis);
        }

        public class BenutzerInteraktion
        {
            public BenutzerInteraktion()
            {

            }

            internal int ErfrageX()
            {
                
                Console.Write("1. Zahl: ");
                return Convert.ToInt32(Console.ReadLine());
            }

            internal int ErfrageY()
            {
                Console.Write("1. Zahl: ");
                return Convert.ToInt32(Console.ReadLine());
            }

            internal void Ausgabe(int x, int y, List<int> listeX, List<int> listeY, int ergebnis)
            {
                Console.Clear();
                int iteration = 0;

                Console.Write($"{x,5}"); Console.Write($"{"*",8}"); Console.Write($"{y,10}\n");
                Console.WriteLine("--------------------------");
                foreach(int item in listeX)
                {
                    Console.WriteLine($"{listeX[iteration],5} {listeY[iteration],17}");
                    iteration++;
                }
                Console.WriteLine("==========================");
                Console.Write($"{"Ergebnis:",0}"); Console.Write($"{ergebnis,14}");
                Console.ReadLine();
            }
        }

        public class Manipulation
        {
            public Manipulation()
            {

            }

            internal List<int> ListeX(int x)
            {
                List<int> listeX = new List<int>();

                while (x != 0)
                {
                    listeX.Add(x);
                    x = x / 2;
                }
                return listeX;
            }

            internal List<int> ListeY(int x, int y)
            {
                List<int> listeY = new List<int>();

                while (x != 0)
                {
                    listeY.Add(y);
                    x = x / 2;
                    y = y * 2;
                }
                return listeY;
            }

            internal int ErgebnisBerechnung(List<int> listeX, List<int> listeY)
            {
                int ergebnis = 0;
                List<int> yBerechnung = new List<int>();
                int iteration = 0;

                foreach (int item in listeX)
                {
                    if (item % 2 != 0)
                    {
                        yBerechnung.Add(listeY[iteration]);
                    }
                    iteration++;
                }
                ergebnis = yBerechnung.Sum();
                return ergebnis;
            }
        }
    }
}
