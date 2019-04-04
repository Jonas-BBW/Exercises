using NUnit.Framework;

namespace NUnit
{
    [TestFixture]
    public class Tests
    {
        [Test, Category("Gerüsttest")]
        public static void TestGewinnen()
        {
            var zufallszahl = Ratespiel.Ratespiel.GeneriereZufallszahl();
            var eingabeGleichZufallszahl = Ratespiel.Ratespiel.PrüfeEingabe(zufallszahl, zufallszahl);
            Assert.AreEqual(true, eingabeGleichZufallszahl);
        }
        [Test, Category("Gerüsttest")]
        public static void TestVerlieren()
        {
            var zufallszahl = Ratespiel.Ratespiel.GeneriereZufallszahl();
            var eingabeGleichZufallszahl = Ratespiel.Ratespiel.PrüfeEingabe(zufallszahl, zufallszahl + 1);
            Assert.AreEqual(false, eingabeGleichZufallszahl);
        }
    }
}
