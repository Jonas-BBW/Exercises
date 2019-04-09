using NUnit.Framework;
using PalindromTester;

namespace NUnit
{
    [TestFixture]
    public class Tests
    {
        [Test, Category("Verarbeitungstest")]
        public static void Verarbeitungstest()
        {
            Assert.IsTrue(Program.UntersucheAufPalindromie("reittier"));
        }
    }
}