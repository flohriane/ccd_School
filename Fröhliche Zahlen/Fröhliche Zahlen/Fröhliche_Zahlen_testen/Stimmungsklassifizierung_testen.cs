using NUnit.Framework;
using zahlenakrobatik;

namespace Fröhliche_Zahlen_testen
{
    [TestFixture]
    class Stimmungsklassifizierung_testen
    {
        [Test]
        public void Zahl_ist_fröhlich()
        {
            Assert.IsTrue(Stimmungsklassifizierung.Fröhlichkeit_bestimmen(1));
            Assert.IsTrue(Stimmungsklassifizierung.Fröhlichkeit_bestimmen(7));
            Assert.IsTrue(Stimmungsklassifizierung.Fröhlichkeit_bestimmen(19));
        }
        
        
        [Test]
        public void Zahl_ist_traurig()
        {
            Assert.IsFalse(Stimmungsklassifizierung.Fröhlichkeit_bestimmen(5));
            Assert.IsFalse(Stimmungsklassifizierung.Fröhlichkeit_bestimmen(12));
            Assert.IsFalse(Stimmungsklassifizierung.Fröhlichkeit_bestimmen(101));
        }
    }
}