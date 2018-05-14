using System.Collections.Generic;
using spellchecker;
using NUnit.Framework;

namespace spellchecker_Tests
{
    [TestFixture]
    public class Spellchecker_Testing
    {
        [Test]
        public void Text_splitten()
        {
            var ergebnis = Spellchecker.Text_in_Wörter_zerlegen(@"Das .     ist !? mal " + "\r" + "\n" + " ein Text . zum" + "\t" + " ,,, Testen " + "\b" + " ; " + "\v");
            Assert.AreEqual(new[] { "Das", "ist", "mal", "ein", "Text", "zum", "Testen" }, ergebnis);
        }

        [Test]
        public void Fehler_finden()
        {
            var wörter = new[] {"Brinen", "Aeppel"};
            var lexikon =  new HashSet<string>(new[] {"Äpfel", "Birnen", "Kirschen", "Aprikosen", "Pflaumen"});
            var ergebnis = Spellchecker.Wörter_auf_Fehler_überprüfen(wörter, lexikon);
            Assert.AreEqual(new[] { "Brinen", "Aeppel" }, ergebnis.ToArray());
        }
    }
}
