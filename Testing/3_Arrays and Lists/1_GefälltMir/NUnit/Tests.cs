using System;
using System.Collections.Generic;
using System.IO;
using NUnit.Framework;
using GefälltMir;

namespace NUnit
{
    [TestFixture]
    public class Tests
    {
        [Test, Category("eine Person")]
        public static void EinGefälltMirTest()
        {
            var ergebnisAusgabe = new StringWriter();
            Console.SetOut(ergebnisAusgabe);

            var namenListe = new List<string>() { "Jonas" };
            Program.Ausgabe(namenListe);
            Assert.AreEqual("Jonas mag deinen Beitrag.", ergebnisAusgabe.ToString().Remove(ergebnisAusgabe.ToString().Length - 2)); 
        }
        [Test, Category("zwei Personen")]
        public static void ZweiGefälltMirTest()
        {
            var ergebnisAusgabe = new StringWriter();
            Console.SetOut(ergebnisAusgabe);

            var namenListe = new List<string>() { "Jonas", "Alexander" };
            Program.Ausgabe(namenListe);
            Assert.AreEqual("Jonas und Alexander mögen deinen Beitrag.", ergebnisAusgabe.ToString().Remove(ergebnisAusgabe.ToString().Length - 2));
        }
        [Test, Category("viele Personen")]
        public static void VieleGefälltMirTest()
        {
            var ergebnisAusgabe = new StringWriter();
            Console.SetOut(ergebnisAusgabe);

            var namenListe = new List<string>() { "Jonas", "Alexander", "Martti", "Amedeo", "Christopher", "Marius", "Felix", "Felix", "Jonas", "Hannes", "Maximilian", "David", "Marvin" };
            Program.Ausgabe(namenListe);
            Assert.AreEqual("Jonas, Alexander und 11 Weitere mögen deinen Beitrag.", ergebnisAusgabe.ToString().Remove(ergebnisAusgabe.ToString().Length - 2));
        }
    }
}