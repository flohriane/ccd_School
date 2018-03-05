using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using zahlenakrobatik;

namespace Fröhliche_Zahlen_testen
{
    [TestFixture]
    public class Fröhliche_Zahlen_test
    {
        [Test]
        public void Fröhliche_Zahlen_finden()
        {
            var result = Fröhliche_Zahlen.Zahlen_verarbeiten(10,20);
            Assert.AreEqual(new[]{10, 13, 19}, result.ToArray());
        }


        [Test]
        public void Zahlenbereich_generieren_wenn_Grenzen_gleich()
        {
            var result = Fröhliche_Zahlen.Zahlenbereich_festlegen(3, 3);
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(false, result[3]);
        }
        
        [Test]
        public void Zahlenbereich_generieren_wenn_Grenzen_ungleich()
        {
            var result = Fröhliche_Zahlen.Zahlenbereich_festlegen(7, 9);
            Assert.AreEqual(3, result.Count);
            Assert.AreEqual(false, result[7]);
            Assert.IsFalse(result[8]);
            Assert.IsFalse(result[9]);
        }


        [Test]
        public void Destillation()
        {
            var zahlenbereich = new Dictionary<int,bool>{{19,false}, {7,true}, {-1,true}, {123,false}};
            var result = Fröhliche_Zahlen.Markierte_destillieren(zahlenbereich);
            Assert.AreEqual(new[]{7,-1}, result.ToArray());
        }
    }
}