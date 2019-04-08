using System;

namespace AstronomischeStundenzählung
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            var richtigeUhrzeit = HoleUhrzeit();
            Ausgabe(richtigeUhrzeit);
        }
        internal static bool HoleUhrzeit()
        {
            Console.WriteLine("Bitte geben Sie eine Uhrzeit im 24-Stunden-Format an! (z.B. 13:30)");
            try
            {
                Convert.ToDateTime(Console.ReadLine());
            }
            catch
            {
                return false;
            }
            return true;
        }
        private static void Ausgabe(bool richtigeUhrzeit)
        {
            Console.WriteLine(richtigeUhrzeit ? "In Ordnung!" : "Falsche Eingabe!");
        }
    }
}
