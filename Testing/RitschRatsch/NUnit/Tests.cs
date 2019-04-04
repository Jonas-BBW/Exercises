using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using RitschRatsch;

namespace NUnit
{
    class Tests
    {
        [TestFixture]

        public class Test1
        {
            [Test, Category("Gerüsttest")]
            public void Berechnung()
            {
                List<string> eingabeListe = "1,2,Ritsch,4,Ratsch,Ritsch,7,8,Ritsch,Ratsch,11,Ritsch,13,14,RitschRatsch".Split(',').ToList();
                List<string> ergebnis = new cons_RitschRatsch.Problemlösung().Berechnung(1, 16);
                Assert.AreEqual(eingabeListe, ergebnis);
            }
        }
    }
}
