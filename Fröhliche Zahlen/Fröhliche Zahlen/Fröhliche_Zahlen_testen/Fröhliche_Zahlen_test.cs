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
    }
}