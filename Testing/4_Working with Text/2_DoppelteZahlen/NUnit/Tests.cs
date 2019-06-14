using System.Collections.Generic;
using NUnit.Framework;
using DoppelteZahlen;

namespace NUnit
{
    [TestFixture]
    public class Tests
    {
        [Test, Category("Verarbeitungstest")]
        public static void Verarbeitungstest()
        {
            var ergebnis = Program.HoleDoppelteEinträge(new List<int>{ 1, 1, 2, 3, 4, 4, 5, 5 });
            Assert.AreEqual(new List<int>{ 1, 4, 5 }, ergebnis);
        }
    }
}
