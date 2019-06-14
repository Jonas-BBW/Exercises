using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using NUnit.Framework;
using Zahleneingabe;

namespace NUnit
{
    [TestFixture]
    public class Tests
    {
        [Test, Category("Verarbeitungstest")]
        public static void Verarbeitungstest()
        {
            var pseudoEingabeString = new MemoryStream(Encoding.UTF8.GetBytes("ende"));
            var eingabe = new StreamReader(pseudoEingabeString);
            Console.SetIn(eingabe);

            Assert.AreEqual(new List<string>(){}, Program.ErstelleZahlenListe());
        }
        [Test, Category("Ausgabetest")]
        public static void Ausgabetest()
        {
            var ergebnisAusgabe = new StringWriter();
            Console.SetOut(ergebnisAusgabe);
            Program.Ausgabe(new List<int>() {1,2,3});

            Assert.AreEqual("1, 2, 3",ergebnisAusgabe.ToString().Remove(ergebnisAusgabe.ToString().Length - 2));
        }
    }
}
