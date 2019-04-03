using System;
using System.Data;

namespace Temperaturumrechner
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var temperatur = HoleTemp();
            var gegeben = HoleEinheit();

            switch (gegeben)
            {
                case "1":
                    Ausgabe(BerechneFahrenheit(temperatur));
                    break;
                case "2":
                    Ausgabe(BerechneCelsius(temperatur));
                    break;
            }
        }
        private static double HoleTemp()
        {
            Console.WriteLine("Geben Sie die Temperatur an!");
            return Convert.ToDouble(Console.ReadLine());
        }
        private static string HoleEinheit()
        {
            Console.WriteLine("In welcher Einheit wurde die Temperatur angegeben?");
            Console.WriteLine("Celsius(1) oder Fahrenheit(2)");

            var einheit = "1";

            switch (Console.ReadLine())
            {
                case "1":
                    return einheit;
                case "2":
                    einheit = "2";
                    return einheit;
                default:
                    return einheit;
            }
        }
        internal static string BerechneFahrenheit(double temperatur)
        {
            var berechnungsString = "(" + temperatur + "*9/5)+32";
            return new DataTable().Compute(berechnungsString, null).ToString();
        }
        internal static string BerechneCelsius(double temperatur)
        {
            var berechnungsString = "(" + temperatur + "- 32)*5/9";
            return new DataTable().Compute(berechnungsString, null).ToString();
        }
        private static void Ausgabe(string ergebnis)
        {
            Console.WriteLine("Das Ergebnis lautet: {0}.", ergebnis);
        }
    }
}