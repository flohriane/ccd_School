using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using happy_numbers;
using NUnit.Framework;
using System.Threading.Tasks;

namespace happy_numbers_testen
{
    [TestFixture]
    public class Happy_Numbers_Tests
    {
        [Test, Category("Akzeptanztest")]
        public void Happy_Numbers_finden()
        {
            var result = Happy_Numbers.Zahlenliste_erstellen(1, 20);
            Assert.AreEqual(new[] { 1, 7, 10, 13, 19 }, result.ToArray());
        }

        [Test, Category("Gerüsttest")]
        public void Happy_Numbers_Bereich_festlegen()
        {
            var result = Happy_Numbers.Zahlenbereich_festlegen(10, 20);
            Assert.IsFalse(result[10]);
            Assert.AreEqual(11, result.Count);
        }

        [Test, Category("Gerüsttest")]
        public void Zahl_in_Ziffern_zerlegen()
        {
            var result = Happy_Numbers.Zahl_in_Ziffern_zerlegen(189);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(8, result[1]);
            Assert.AreEqual(9, result[2]);
            Assert.AreEqual(3, result.Length);
        }

        [Test, Category("Gerüsttest")]
        public void Quadrierte_Summen_berechnen()
        {
            var result = Happy_Numbers.Quadrierte_Summen_berechnen(19);
            Assert.AreEqual(82, result);
        }

        [Test, Category("Gerüsttest")]
        public void Traurig_oder_fröhlich()
        {
            var result = Happy_Numbers.Traurig_oder_Fröhlich(1);
            Assert.IsTrue(result);

            result = Happy_Numbers.Traurig_oder_Fröhlich(1009);
            Assert.IsTrue(result);

            result = Happy_Numbers.Traurig_oder_Fröhlich(11);
            Assert.IsFalse(result);

            result = Happy_Numbers.Traurig_oder_Fröhlich(002);
            Assert.IsFalse(result);
        }

        [Test, Category("Gerüsttest")]
        public void Fröhliche_Zahlen_extrahieren()
        {
            Dictionary<int, bool> zahlenbereich = new Dictionary<int, bool>();
            zahlenbereich.Add(10, true);
            zahlenbereich.Add(19, true);
            zahlenbereich.Add(1009, true);
            zahlenbereich.Add(1, true);
            zahlenbereich.Add(11, false);

            var result = Happy_Numbers.Fröhliche_Zahlen_extrahieren(zahlenbereich);
            Assert.AreEqual(10, result[0]);
            Assert.AreEqual(19, result[1]);
            Assert.AreEqual(1, result[3]);
            Assert.AreEqual(4, result.Count);
        }
    }
}
