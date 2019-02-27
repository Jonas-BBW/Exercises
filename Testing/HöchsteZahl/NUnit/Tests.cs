using System;
using System.IO;
using NUnit.Framework;
using HöchsteZahl;
using System.Collections.Generic;
using System.Linq;

namespace NUnit
{
    public class Tests
    {
        [TestFixture]
        public class Test1
        {
            [Test, Category("Gerüsttest")]
            public void Berechnung()
            {
                List<int> test = new List<int>();
                test.Add(7);
                test.Add(88);
                test.Add(66);
                test.Add(55);
                test.Add(11);

                int ergebnis = cons_HöchsteZahl.ErkenneZahl(test);
                Assert.AreEqual(ergebnis, 88);
            }
        }
    }
}
