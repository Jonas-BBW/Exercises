using NUnit.Framework;
using Taschenrechner;
namespace NUnit
{
    [TestFixture]
    public class Tests
    {
        [Test, Category("Gerüsttest")]
        public void Plus()
        {
            double ergebnis = cons_Taschenrechner.Berechne(5, 5, '+');
            Assert.AreEqual(10, ergebnis);
        }

        [Test, Category("Gerüsttest")]
        public void Minus()
        {
            double ergebnis = cons_Taschenrechner.Berechne(5, 5, '-');
            Assert.AreEqual(0, ergebnis);
        }

        [Test, Category("Gerüsttest")]
        public void Mal()
        {
            double ergebnis = cons_Taschenrechner.Berechne(5, 5, '*');
            Assert.AreEqual(25, ergebnis);
        }

        [Test, Category("Gerüsttest")]
        public void Durch()
        {
            double ergebnis = cons_Taschenrechner.Berechne(5, 5, ':');
            Assert.AreEqual(1, ergebnis);
        }
    }
}
