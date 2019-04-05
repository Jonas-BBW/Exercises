using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Fröhliche_Zahlen;

namespace NUnit
{
    [TestFixture]
    public class UnitTests
    {
        [Test, Category("Gerüsttest")]
        public void FröhlicheZahl()
        {
            string variable = con_fröhlicheZahlen.Fröhlichkeitsprüfung("100");
            Assert.AreEqual(variable, "1");
        }

        [Test, Category("Gerüsttest")]
        public void TraurigeZahl()
        {
            string variable = con_fröhlicheZahlen.Fröhlichkeitsprüfung("2");
            Assert.AreEqual(variable, "4");
        }
    }
}
