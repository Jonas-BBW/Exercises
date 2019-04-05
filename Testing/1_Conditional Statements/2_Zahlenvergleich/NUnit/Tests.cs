using NUnit.Framework;
using Zahlenvergleich;

namespace NUnit
{
    [TestFixture]
    public class Tests1
    {
        [Test, Category("Akzeptanztest")]
        public static void ZahlenVergleich()
        {
            var größereZahl = Program.ErkenneGrößereZahl(5,6);
            Assert.AreEqual(6,größereZahl);
        }
    }
}