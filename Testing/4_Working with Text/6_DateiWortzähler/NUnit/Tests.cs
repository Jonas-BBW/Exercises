using DateiWortzähler;
using NUnit.Framework;

namespace NUnit
{
    [TestFixture]
    public class Tests
    {
        [Test, Category("Verarbeitungstest")]
        public static void Verarbeitungstest()
        {
            Assert.AreEqual(2, Program.WortZähler());
        }
    }
}
