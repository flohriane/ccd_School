using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using kalender;

namespace kalender_tests
{
    [TestFixture]
    public class Testings_Kalender
    {
        [Test, Category("Akzeptanztest")]
        public static void Teste_Kalenderausgabe()
        {
            // $ kalender.exe 2 2018
            var ergebnis = Monatskalender.Kalender_erstellen(new[]{"2", "2018"});
            Assert.AreEqual(new[]
            {
                "    Februar 2018",
                "So Mo Di Mi Do Fr Sa ",
                "             1  2  3 ",
                " 4  5  6  7  8  9 10 ",
                "11 12 13 14 15 16 17 ",
                "18 19 20 21 22 23 24 ",
                "25 26 27 28 "
            },
            ergebnis.ToArray());
        }

        [Test, Category ("Modultest")]
        public static void Teste_Wochentag()
        {
            var ergebnis = Kalender.Erster_Wochentag_ermitteln(2018, 4);

            Assert.AreEqual("Sunday", ergebnis.ToString());
        }
        
        [Test, Category ("Modultest")]
        public static void Teste_Anzahl_Zeilen()
        {
            var ergebnis = Formatierer.Kalender_formatieren("Februar", 2018, 
                "             1  2  3  4  5  6  7  8  9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 ");

            Assert.AreEqual(7, ergebnis.Count());
        }

    }
}
