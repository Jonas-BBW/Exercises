using NUnit.Framework;

namespace NUnit
{
    [TestFixture]
    public class Tests
    {
        [Test, Category("Gerüsttest")]
        public void BerechneFakultät()
        {
            var ergebnis = Fakultät.Fakultät.BerechneFakultät(5);
            Assert.AreEqual(120, ergebnis);
        }
    }
}
