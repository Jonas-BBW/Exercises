using NUnit.Framework;
using Vokalzähler;

namespace NUnit
{
    [TestFixture]
    public class Tests
    {
        [Test, Category("Verarbeitungstest")]
        public static void Verarbeitungstest()
        {
            Assert.AreEqual(6,Program.WortVerarbeitung("unuebersichtlich"));
        }
    }
}
