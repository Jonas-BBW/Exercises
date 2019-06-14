using NUnit.Framework;

namespace NUnit
{
    public class Tests
    {
        [TestFixture]
        public class Tests1
        {
            [Test, Category("Akzeptanztest")]
            public void Berechnung()
            {
                var ergebnis = cons_EndloseAddition.cons_EndloseAddition.ErgebnisBerechnung("5", 3);
                Assert.AreEqual(8, ergebnis);
            }
        }
    }
}
