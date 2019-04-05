using System;
using System.Linq;

namespace NameRückwärts
{
    public class Program
    {
        internal static void Main(string[] args)
        {
            var name = ErfrageNamen();
            var umgekehrterName = NamenUmkehrung(name);
            Ausgabe(umgekehrterName);
        }
        internal static char[] ErfrageNamen()
        {
            Console.WriteLine("Geben Sie Ihren Namen ein!");
            return Console.ReadLine().ToLower().ToArray();
        }
        internal static char[] NamenUmkehrung(char[] name)
        {
            Array.Reverse(name);
            name[0] = char.ToUpper(name[0]);
            return name;
        }
        internal static void Ausgabe(char[] umgekehrterName)
        {
            foreach (var buchstabe in umgekehrterName)
            {
                Console.Write(buchstabe);
            }
            Console.WriteLine();
        }
    }
}