using NUnit.Framework;
using Blitzer;

namespace NUnit
{
    public class Tests
    {
        [TestFixture]
        public class Test1
        {
            [Test, Category("Akzeptanztest")]
            public void BerechnePunktzahl()
            {
                var punktzahl = Program.BerechnePunktzahl(60, 120);
                Assert.AreEqual(12,punktzahl);
            }
        }
    }
}
