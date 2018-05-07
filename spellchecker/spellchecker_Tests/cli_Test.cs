using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using spellchecker;

namespace spellchecker_Tests
{
    [TestFixture]
    class cli_Test
    {
        [Test]
        public void Eingabe_testen()
        {
            var cli = new CLI(new[] { "a", "b", "c"});

            var ergebnis = cli.Prüfwörter_von_Konsole_holen();
            Assert.AreEqual(2, ergebnis.Count());
        }
    }
}
