using System;
using System.Collections.Generic;

namespace Div3Zwischen1und100
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const int min = 1;
            const int max = 100;

            var liste = ErschaffeListe(min, max);

            Console.WriteLine(liste.Count);
        }
        internal static List<int> ErschaffeListe(int min, int max)
        {
           var liste = new List<int>();
           for (var i = min; i < max; i++)
           {
               if(i % 3 == 0)
                   liste.Add(i);
           }
           return liste;
        }
    }
}