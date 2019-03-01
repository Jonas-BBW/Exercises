using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text; //Benötigt für richtiges Encoding

namespace ROT13
{
    public class View
    {
        public static void Say(string s)
        {
            Console.WriteLine(s);
        }

        public static void Clear()
        {
            Console.Clear();
        }

        public static string Read()
        {
            return Console.ReadLine();
        }

        public List<char> DateiEinlesen(string pfad)
        {
            return File.ReadAllText(pfad).ToUpper().Replace("Ö", "OE").Replace("Ä", "AE").Replace("Ü", "UE").Replace("ß", "SS").ToList();
        }

        public bool DateiExistent(string pfad)
        {
            FileInfo dateigröße = new FileInfo(pfad);

            if (File.Exists(pfad) && dateigröße.Length > 0)
            {
                if (File.Exists(pfad + "_unverändert.txt"))
                    File.Delete((pfad + "_unverändert.txt"));

                File.Copy(pfad, pfad + "_unverändert.txt");
                return true;
            }

            else if (File.Exists(pfad))
            {
                File.Copy(pfad, pfad + "_unverändert.txt");
                return false;
            }

            File.Create(pfad);
            return false;
        }

        public void Speichern(string pfad, string text)
        {
            File.WriteAllText(pfad, text);
        }

        public static string HolePfad()
        {
            Clear();
            Say("Geben Sie den Pfad zur Datei an!");
            return Read();
        }

        public static string HoleText()
        {
            Clear();
            Say("Es wurde keine Datei gefunden. Bitte Geben Sie Ihren Text ein!");
            return Read();
        }
    }
}
