using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using stackv3;
using NUnit.Framework;

namespace stackv3_Tests
{
    [TestFixture]
    public class Stackv3_Tests
    {
        [Test]
        public void PushUndCount()
        {
            var stapel = new Stapel<int>();
            stapel.Push(10);
            stapel.Push(20);
            stapel.Push(30);
            var ergebnis = stapel._zaehler;
            Assert.AreEqual(3, ergebnis);
        }

        [Test]
        public void PeekOberster()
        {
            var stapel = new Stapel<int>();
            stapel.Push(40);
            stapel.Push(41);
            var ergebnis = stapel.Peek().wert;
            var anzahl = stapel._zaehler;
            Assert.AreEqual(41, ergebnis);
            Assert.AreEqual(2, anzahl);
        }
    }
}
