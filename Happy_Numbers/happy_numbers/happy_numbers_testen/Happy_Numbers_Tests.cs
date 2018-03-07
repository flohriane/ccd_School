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
        //[Test, Category("Akzeptanztest")]
        //public void Happy_Numbers_finden()
        //{
        //    var result = Happy_Numbers.Zahlenliste_erstellen(10, 20);
        //    Assert.AreEqual(new[] { 10, 13, 19 }, result.ToArray());
        //}

        [Test, Category("Gerüsttest")]
        public void Happy_Numbers_Bereich_festlegen()
        {
            var result = Happy_Numbers.Zahlenbereich_festlegen(10, 20);
            Assert.IsFalse(result[10]);
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
    }
}
