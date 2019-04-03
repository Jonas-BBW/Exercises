using System;

namespace Gültigkeitsprüfung
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var zahl = HoleZahl();
            var gültigkeit = Gültigkeitsprüfung(zahl);
            Ausgabe(gültigkeit);
        }
        private static int HoleZahl()
        {
            Console.WriteLine("Bitte Geben Sie eine Ganzzahl ein!");
            return Convert.ToInt32(Console.ReadLine());
        }
        internal static string Gültigkeitsprüfung(int zahl)
        {
            if (zahl <= 10 && zahl >= 1)
                return "gültig";
            return "ungültig";
        }
        private static void Ausgabe(string gültigkeit)
        {
            Console.WriteLine(gültigkeit);
        }
    }
}