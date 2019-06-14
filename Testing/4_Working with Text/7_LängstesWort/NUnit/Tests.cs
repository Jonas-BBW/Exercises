using LängstesWort;
using NUnit.Framework;

namespace NUnit
{
    [TestFixture]
    public class Tests
    {
        [Test, Category("Verarbeitungstest")]
        public static void Verarbeitungstest()
        {
            Assert.AreEqual("Accusantium", Program.HoleLängstesWort());
        }
    }
}