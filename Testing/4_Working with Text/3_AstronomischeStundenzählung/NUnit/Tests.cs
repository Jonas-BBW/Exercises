using System;
using System.IO;
using System.Text;
using NUnit.Framework;
using AstronomischeStundenzählung;

namespace NUnit
{
    [TestFixture]
    public class Tests
    {
        [Test, Category("Verarbeitungstest")]
        public static void Verarbeitungstest()
        {
            var pseudoEingabeString = new MemoryStream(Encoding.UTF8.GetBytes("13:37"));
            var eingabe = new StreamReader(pseudoEingabeString);
            Console.SetIn(eingabe);
            
            Assert.IsTrue(Program.HoleUhrzeit());
        }
    }
}
