using NUnit.Framework;
using Fakultät;

namespace NUnit
{
    public class Tests
    {
        [TestFixture]

        public class test1
        {
            [Test, Category("Gerüsttest")]
            public void Berehnung()
            {
                int ergebnis = cons_Fakultät.BerechneFakultät(5, 5);
                Assert.AreEqual(ergebnis, 120);
            }
        }
    }
}
