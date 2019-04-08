using System;
using System.Collections.Generic;
using System.Linq;

namespace GültigkeitsprüfungListe
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var eingabeListe = ErstellungEingabeListe();
            Ausgabe(eingabeListe);
        }
        public static List<int> ErstellungEingabeListe()
        {
            Console.WriteLine("Bitte geben Sie eine mit Kommata getrennte Liste von mindestens fünf Zahlen ein!");
            return Console.ReadLine().Split(',').ToList().ConvertAll(Convert.ToInt32);
        }
        public static string AusgabeString(List<int> eingabeListe)
        {
            var ausgabeListe = eingabeListe.Distinct().OrderBy(a => a).ToList();
            return string.Join(", ", ausgabeListe[0], ausgabeListe[1], ausgabeListe[2]);
        }
        public static void Ausgabe(List<int> eingabeListe)
        {
            Console.WriteLine(eingabeListe.Count <= 4 ? "Ungültige Eingabe!" : AusgabeString(eingabeListe));
        }
    }
}