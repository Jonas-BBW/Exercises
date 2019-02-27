using NUnit.Framework;
using Div3;

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
                var ergebnis = cons_Div3.Berechne(0, 3, 9);
                Assert.AreEqual(3, ergebnis);
            }
        }
    }
}
