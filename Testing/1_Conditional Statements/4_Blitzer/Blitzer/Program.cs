using System;

namespace Blitzer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var punktzahl = 0;
            var höchstGeschwindigkeit = HöchstGeschwindigkeit();
            var aktuelleGeschwindigkeit = AktuelleGeschwindigkeit();

            if (aktuelleGeschwindigkeit <= höchstGeschwindigkeit)
                Console.WriteLine("Okay!");
            else
                punktzahl = BerechnePunktzahl(höchstGeschwindigkeit, aktuelleGeschwindigkeit);

            Console.WriteLine("Punktzahl: {0}", punktzahl);

            if(punktzahl>=12)
                Console.WriteLine("Führerschein wird entzogen.");
        }
        private static int HöchstGeschwindigkeit()
        {
            Console.WriteLine("Bitte geben Sie die Höchstgeschwindigkeit ein!");
            return Convert.ToInt32(Console.ReadLine());
        }
        private static int AktuelleGeschwindigkeit()
        {
            Console.WriteLine("Bitte geben Sie die aktuelle Geschwindigkeit ein!");
            return Convert.ToInt32(Console.ReadLine());
        }
        internal static int BerechnePunktzahl(int höchstGeschwindigkeit, int aktuelleGeschwindigkeit)
        {
            var differenz = aktuelleGeschwindigkeit - höchstGeschwindigkeit;
            return differenz / 5;
        }
    }
}