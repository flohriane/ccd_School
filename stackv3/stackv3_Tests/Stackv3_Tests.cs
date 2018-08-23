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
            var ergebnis = stapel.Count;
            Assert.AreEqual(3, ergebnis);
        }

        [Test]
        public void PeekOberster()
        {
            var stapel = new Stapel<int>();
            stapel.Push(40);
            stapel.Push(41);
            var ergebnis = stapel.Peek();
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
            
            Assert.AreEqual(56, stapel.Peek());
            
            var ergebnis = stapel.Pop();
            Assert.AreEqual(56, ergebnis);
            
            ergebnis = stapel.Pop();
            Assert.AreEqual(51, ergebnis);
            
            ergebnis = stapel.Pop();
            Assert.AreEqual(55, ergebnis);
            
            ergebnis = stapel.Pop();
            Assert.AreEqual(50, ergebnis);
            
            Assert.AreEqual(0, stapel.Count);
        }
    }
}
