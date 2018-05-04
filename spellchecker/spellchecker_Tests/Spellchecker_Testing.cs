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
        public void Fehler_gefunden()
        {
            var ergebnis = Spellchecker_Start.Wörter_auf_Fehler_überprüfen(new [] {"Äpfel", "Birnen", "Kirschen", "Aprikosen", "Pflaumen"}, new List<string> {"Brinen", "Äppel"});
            Assert.AreEqual(new[] {"Brinen", "Äppel"}, ergebnis.ToArray());
        }
    }
}
