using System;
using System.IO;
using System.Text;
using NUnit.Framework;

namespace NUnit
{
    [TestFixture]
    public class Tests
    {
        [Test, Category("TestGewinnen")]
        public static void TestGewinnen()
        {
            var pseudoEingabeString = new MemoryStream(Encoding.UTF8.GetBytes("5"));
            var eingabe = new StreamReader(pseudoEingabeString);
            Console.SetIn(eingabe);
            Assert.AreEqual("gewonnen", Ratespiel.Ratespiel.Spiel(5));
        }
        [Test, Category("TestVerlieren")]
        public static void TestVerlieren()
        {
            var pseudoEingabeString = new MemoryStream(Encoding.UTF8.GetBytes("5"));
            var eingabe = new StreamReader(pseudoEingabeString);
            Console.SetIn(eingabe);
            Assert.AreEqual("verloren", Ratespiel.Ratespiel.Spiel(6));
        }
    }
}
