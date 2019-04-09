using System;
using System.Linq;

namespace PalindromTester
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            var eingabe = HoleWort();
            var palindrom = UntersucheAufPalindromie(eingabe);
            Ausgabe(palindrom);
        }

        private static string HoleWort()
        {
            Console.WriteLine("Bitte geben Sie das Wort, bei dem ein Verdacht auf Palindromie besteht ein!");
            return Console.ReadLine().ToLower();
        }
        internal static bool UntersucheAufPalindromie(string eingabe)
        {
            var umgekehrteReihenfole = eingabe.ToLower().Reverse().ToArray();
            return eingabe == string.Join("", umgekehrteReihenfole)  ?  true : false;
        }
        private static void Ausgabe(bool palindrom)
        {
            Console.WriteLine(palindrom ? "Der Verdacht hat sich bestätigt!" : "Der Patient ist gesund.");
        }
    }
}