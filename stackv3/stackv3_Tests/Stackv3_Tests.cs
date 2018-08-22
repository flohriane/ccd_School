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
            Assert.AreEqual(41, ergebnis);
        }

        [Test]
        public void PopUndCount()
        {
            var stapel = new Stapel<int>();
            stapel.Push(50);
            stapel.Push(55);
            stapel.Push(51);
            stapel.Push(56);
            var ergebnis = stapel.Pop().wert;
            var anzahl = stapel._zaehler;
            Assert.AreEqual(3, anzahl);
            Assert.AreEqual(51, ergebnis);

            ergebnis = stapel.Pop().wert;

            ergebnis = stapel.Pop().wert;
            anzahl = stapel._zaehler;
            Assert.AreEqual(1, anzahl);
            Assert.AreEqual(50, ergebnis);

            var leer = stapel.Pop();
            anzahl = stapel._zaehler;
            Assert.AreEqual(0, anzahl);
            Assert.AreEqual(null, leer);
        }
    }
}
