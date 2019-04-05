using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace NUnit
{
    [TestFixture]
    public class Tests
    {
        [Test, Category("Verarbeitungstest1")]
        public static void Verarbeitungstest1()
        {
            var format = Bildformat.Bildformat.Vergleichen(1920, 1080);
            Assert.AreEqual("Querformat", format);
        }

        [Test, Category("Verarbeitungstest2")]
        public static void Verarbeitungstest2()
        {
            var format = Bildformat.Bildformat.Vergleichen(1080, 1920);
            Assert.AreEqual("Hochformat", format);
        }
    }
}
