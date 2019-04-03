using NUnit.Framework;
using Temperaturumrechner;

namespace NUnit
{
    [TestFixture]
    public class Tests
    {
        [Test, Category("Gerüsttest")]
        public static void TesteCelsiusBerechnung()
        {
            var ergebnis = Program.BerechneCelsius(50);
            Assert.AreEqual("10",ergebnis);
        }
        [Test, Category("Gerüsttest")]
        public static void TesteFahrenheitBerechnung()
        {
            var ergebnis = Program.BerechneFahrenheit(25);
            Assert.AreEqual("77", ergebnis);
        }
    }
}
