using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fröhliche_Zahlen;  // warum unnötig - ich will den namespace doch nutzen ???
using NUnit.Framework;

namespace Fröhliche_Zahlen_testen
{
[TestFixture]
    public class Class1
    {
        [Test]
        public void Fröhliche_Zahlen_finden()
        {
            var result = Fröhliche_Zahlen.Fröhliche_Zahlen.Zahlen_verarbeiten(10,20); // gibt Dictionary<int, bool> zurück
            Assert.AreEqual(true, result[10]);
            Assert.AreEqual(false, result[11]);
            Assert.AreEqual(true, result[19]);
            Assert.AreEqual(21, result.Count);
        }
    }
}