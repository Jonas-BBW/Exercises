using System;
using System.IO;
using NUnit.Framework;
using FünfZahlen;

namespace NUnit
{
    [TestFixture]
    public class Tests
    {
        [Test, Category("Gerüsttest")]
        public static void Gerüsttest()
        {
            var zahlenArray = new int[5] {4, 2, 5, 1, 3};
            var ergebnisAusgabe = new StringWriter();
            Console.SetOut(ergebnisAusgabe);
            Program.Ausgabe(zahlenArray);
            Assert.AreEqual("12345", ergebnisAusgabe.ToString().Remove(ergebnisAusgabe.ToString().Length - 2));
        }
    }
}