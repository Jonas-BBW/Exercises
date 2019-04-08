using System.Collections.Generic;
using NUnit.Framework;
using GültigkeitsprüfungListe;

namespace NUnit
{
    [TestFixture]
    public class Tests
    {
        [Test, System.ComponentModel.Category("Gerüsttest")]
        public static void Test1()
        {
            var ergebnis = Program.AusgabeString(new List<int>() {6, 4, 2, 1, 3});
            Assert.AreEqual("1, 2, 3", ergebnis);
        }
    }
}