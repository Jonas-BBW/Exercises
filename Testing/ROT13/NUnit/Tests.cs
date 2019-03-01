using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ROT13;
using System.IO;

namespace NUnit
{
    [TestFixture]
    public class Tests
    {
        [Test, Category("Lesetest")]
        public void LeseTest()
        {
            string dateiInhalt = string.Join("", new View().DateiEinlesen(@"Z:\Desktop\Lesetest.txt"));
            Assert.AreEqual("TEST", dateiInhalt);
        }

        [Test, Category("Verschlüsselung")]
        public void Verschlüsselung()
        {
            //File.Create(@"Z:\Desktop\tmp_Verschlüsselungstest.txt");
            //File.WriteAllText(@"Z:\Desktop\tmp_Verschlüsselungstest.txt", "ABCDEFGHIJKLMNOPQRSTUVWXYZÖÄÜß");
            string verschlüsselterText = new Model().Verarbeitung(@"Z:\Desktop\tmp_Verschlüsselungstest.txt");
            Assert.AreEqual("NOPQRSTUVWXYZABCDEFGHIJKLMBRNRHRFF", verschlüsselterText);
            //File.Delete(@"Z:\Desktop\tmp_Entschlüsselungstest.txt");
        }

        [Test, Category("Entschlüsselung")]
        public void Entschlüsselung()
        {
            //File.Create(@"Z:\Desktop\tmp_Entschlüsselungstest.txt");
            //File.WriteAllText(@"Z:\Desktop\tmp_Entschlüsselungstest.txt", "NOPQRSTUVWXYZABCDEFGHIJKLMBRNRHRFF");
            string entschlüsselterText = new Model().Verarbeitung(@"Z:\Desktop\tmp_Entschlüsselungstest.txt");
            Assert.AreEqual("ABCDEFGHIJKLMNOPQRSTUVWXYZOEAEUESS", entschlüsselterText);
            //File.Delete(@"Z:\Desktop\tmp_Entschlüsselungstest.txt");
        }
    }
}
