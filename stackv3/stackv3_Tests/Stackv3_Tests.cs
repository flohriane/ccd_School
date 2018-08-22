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
            var ergebnis = stapel.zaehler;
            Assert.AreEqual(3, ergebnis);
        }
    }
}
