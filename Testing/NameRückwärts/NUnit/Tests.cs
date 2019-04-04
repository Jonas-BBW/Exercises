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
        [Test, Category("Akzeptanztest")]
        public static void Akzeptanztest()
        {
            var pseudoEingabeString = new MemoryStream(Encoding.UTF8.GetBytes("Jonas"));
            var eingabe = new StreamReader(pseudoEingabeString);
            Console.SetIn(eingabe);
            var name = Program.ErfrageNamen();
            
            var umgekehrterName = Program.NamenUmkehrung(name);

            var ergebnisAusgabe = new StringWriter();
            Console.SetOut(ergebnisAusgabe);
            Program.Ausgabe(umgekehrterName);

            Assert.AreEqual("Sanoj", ergebnisAusgabe.ToString().Remove(ergebnisAusgabe.ToString().Length - 2));
        }
    }
}