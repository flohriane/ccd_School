using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using spellchecker;
using NUnit.Framework;

namespace spellchecker_Tests
{
    [TestFixture]
    public class Spellchecker_Testing
    {
        [Test, Category ("Akzeptanztest")]
        public void Fehler_gefunden ()
        {
            var ergebnis = Spellchecker_Start.Wörter_prüfen(new[] {"Äpfel", "Birnen", "Kirschen"}, new[] {"Äppel", "Brinen", "Kirschen"});
            Assert.AreEqual(new[] {"Äppel", "Birnen",""}, ergebnis.ToArray());
        }
    }
}
