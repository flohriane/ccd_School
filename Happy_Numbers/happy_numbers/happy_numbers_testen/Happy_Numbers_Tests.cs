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
        
        [Test, Category("Akzeptanztest")]
        public void Happy_Numbers_finden_2()
        {
            var result = Happy_Numbers.Zahlenliste_erstellen(6, 10);
            Assert.AreEqual(new[] { 7, 10 }, result.ToArray());
        }
        
        [Test, Category("Akzeptanztest")]
        public void Happy_Numbers_finden_3()
        {
            var result = Happy_Numbers.Zahlenliste_erstellen(20, 1);
            Assert.AreEqual(0, result.Count());
        }
    }
}
