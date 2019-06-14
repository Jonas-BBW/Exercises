using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ZuPascalCase;

namespace NUnit
{
    [TestFixture]
    public class Tests
    {
        [Test, Category("Verarbeitungstest")]
        public static void Verarbeitungstest()
        {
            Assert.AreEqual("HalloWelt", Program.EingabeVerarbeiten("hallo WELT".ToLower()));
        }
    }
}
