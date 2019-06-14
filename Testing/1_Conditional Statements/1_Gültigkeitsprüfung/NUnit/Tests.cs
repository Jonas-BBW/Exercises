using NUnit.Framework;
using Gültigkeitsprüfung;

namespace NUnit
{
    [TestFixture]
    public class Tests
    {
        [Test, Category("Gerüsttest")]
        public static void TesteGültigkeitsprüfungGültig()
        {
            var gültigkeit = Program.Gültigkeitsprüfung(5);
            Assert.AreEqual("gültig", gültigkeit);
        }
        [Test, Category("Gerüsttest")]
        public static void TesteGültigkeitsprüfungUngültig()
        {
            var gültigkeit = Program.Gültigkeitsprüfung(11);
            Assert.AreEqual("ungültig", gültigkeit);
        }
    }
}
