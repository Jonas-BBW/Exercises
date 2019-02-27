using System.Collections.Generic;
using NUnit.Framework;
using Bauernmultiplikation;

namespace NUnit
{
    
    class Tests
    {
        [TestFixture]
        public class Testklasse
        {
            [Test, Category("Gerüsttest")]
            public void Berechnung()
            {
                List<int> listeX = new List<int>();
                listeX.Add(47);
                listeX.Add(23);
                listeX.Add(11);
                listeX.Add(5);
                listeX.Add(2);
                listeX.Add(1);

                List<int> listeY = new List<int>();
                listeY.Add(42);
                listeY.Add(84);
                listeY.Add(168);
                listeY.Add(336);
                listeY.Add(672);
                listeY.Add(1344);

                var ergebnis = new cons_Bauernmultiplikation.Manipulation().ErgebnisBerechnung(listeX, listeY);

                Assert.AreEqual(1974, ergebnis);
            }

            [Test, Category("Gerüsttest")]
            public void ListeY()
            {
                List<int> listeY = new List<int>();
                listeY.Add(42);
                listeY.Add(84);
                listeY.Add(168);
                listeY.Add(336);
                listeY.Add(672);
                listeY.Add(1344);

                var ergebnis = new cons_Bauernmultiplikation.Manipulation().ListeY(47, 42);

                Assert.AreEqual(listeY, ergebnis);
            }

            [Test, Category("Gerüsttest")]
            public void ListeX()
            {
                List<int> listeX = new List<int>();
                listeX.Add(47);
                listeX.Add(23);
                listeX.Add(11);
                listeX.Add(5);
                listeX.Add(2);
                listeX.Add(1);

                var ergebnis = new cons_Bauernmultiplikation.Manipulation().ListeX(47);

                Assert.AreEqual(listeX, ergebnis);
            }

            [Test, Category("AKzeptanztest")]
            public void Akzeptanztest()
            {
                var listeX = new cons_Bauernmultiplikation.Manipulation().ListeX(47);
                var listeY = new cons_Bauernmultiplikation.Manipulation().ListeY(47, 42);
                new cons_Bauernmultiplikation.Manipulation().ErgebnisBerechnung(listeX, listeY);
            }
        }
    }
}
