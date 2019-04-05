using System;
using System.IO;
using System.Text;
using NUnit.Framework;
using NameRückwärts;

namespace NUnit
{
    [TestFixture]
    public class Tests
    {
        [Test, Category("Eingabetest")]
        public static void Eingabetest()
        {
            var pseudoEingabeString = new MemoryStream(Encoding.UTF8.GetBytes("Jonas"));
            var eingabe = new StreamReader(pseudoEingabeString);
            Console.SetIn(eingabe);
            Assert.AreEqual("jonas", Program.ErfrageNamen());
        }

        [Test, Category("Verarbeitungstest")]
        public static void Verarbeitungstest()
        {
            Assert.AreEqual("Sanoj", Program.NamenUmkehrung("jonas".ToCharArray()));
        }

        [Test, Category("Ausgabetest")]
        public static void Ausgabetest()
        {
            var ergebnisAusgabe = new StringWriter();
            Console.SetOut(ergebnisAusgabe);
            Program.Ausgabe("Sanoj".ToCharArray());

            Assert.AreEqual("Sanoj", ergebnisAusgabe.ToString().Remove(ergebnisAusgabe.ToString().Length - 2));
        }
    }
}