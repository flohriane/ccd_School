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
            var result = Fröhliche_Zahlen.Fröhliche_Zahlen.Zahlen_verarbeiten(10,20); // gibt List<int> zurück
            
            // Wie prüfe ich, dass Einträge in der Liste sind ??? Bedingung ???
            Assert.???(result[10]);
            Assert.???(result[19]);
        }
    }
}