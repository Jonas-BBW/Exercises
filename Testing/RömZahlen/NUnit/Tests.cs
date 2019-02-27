using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RömZahlen;

namespace NUnit
{
    public class Tests
    {
        [TestFixture]
        public class Testklasse
        {
            [Test, Category("Gerüsttest")]
            public void Test1()
            {
                List<char> eingabeListe = "MCCXXXIV".ToCharArray().ToList();
                int ergebnis = new cons_RömZahlen.Manipulation().Übersetzung(eingabeListe);
                Assert.AreEqual(1234, ergebnis);
            }
        }
    }
}
