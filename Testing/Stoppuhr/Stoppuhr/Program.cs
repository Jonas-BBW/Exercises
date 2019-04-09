using System;

namespace Stoppuhr
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            Console.WriteLine("Geben Sie \"S\" ein, um die Stoppuhr zu starten!");
            if (Console.ReadLine() == "S")
                Stoppuhr();
        }
        internal static void Stoppuhr()
        {
            var stoppuhr = new System.Timers.Timer();
            var startZeit = DateTime.Now;
            stoppuhr.Enabled = true;

            while (true)
            {
                var eingabe = Console.ReadLine();

                if (eingabe == "R")
                {
                    var dauer = DateTime.Now - startZeit;
                    Console.Write("Rundenzeit: {0}", dauer);
                }

                if (eingabe == "E")
                {
                    var dauer = DateTime.Now - startZeit;
                    Console.WriteLine("Gesamtdauer: {0}", dauer);
                    stoppuhr.Stop();
                    break;
                }
            }
        }
    }
}