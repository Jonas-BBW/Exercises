using NUnit.Framework;
using Div3Zwischen1und100;

namespace NUnit
{
    public class Tests
    {
        [TestFixture]
        public class Tests1
        {
            [Test, Category("Akzeptanztest")]
            public void Berechnung()
            {
                var menge = Program.ErschaffeListe(1, 100).Count;
                Assert.AreEqual(33,menge);
            }
        }
    }
}