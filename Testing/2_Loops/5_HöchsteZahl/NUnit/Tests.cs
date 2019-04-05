using NUnit.Framework;
using System.Collections.Generic;

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
                var test = new List<int>();
                test.Add(7);
                test.Add(88);
                test.Add(66);
                test.Add(55);
                test.Add(11);

                var ergebnis = HöchsteZahl.HöchsteZahl.ErkenneZahl(test);
                Assert.AreEqual(ergebnis, 88);
            }
        }
    }
}