using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Zahlenabfolge;

namespace NUnit
{
    [TestFixture]
    public class Tests
    {
        [Test, Category("Abfolge1")]
        public static void Abfolge1()
        {
            Assert.IsTrue(Program.VergleicheZahlen(new List<int> {1, 2, 3, 4, 5}));
        }
        [Test, Category("Abfolge2")]
        public static void Abfolge2()
        {
            Assert.IsTrue(Program.VergleicheZahlen(new List<int> { 50, 49, 48, 47, 46 }));
        }
        [Test, Category("KeineAbfolge")]
        public static void KeineAbfolge()
        {
            Assert.IsFalse(Program.VergleicheZahlen(new List<int> { 3, 4, 1, 2, 5 }));
        }
    }
}
