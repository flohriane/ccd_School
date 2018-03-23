using NUnit.Framework;
using more;

namespace more_tests
{
    [TestFixture]
    public class PagewisePresentation_tests
    {
        [Test]
        public void Zeilen_erzeugen()
        {
            var sut = new PagewisePresentation();
            var result = sut.Zeilen_erzeugen("a\nb\r\nc");
            Assert.AreEqual(new[]{"a","b","c"}, result);
        }


        [Test]
        public void Seiten_erzeugen()
        {
            var sut = new PagewisePresentation();
            var result = sut.Seiten_erzeugen(new[] {"1", "2", "3", "4", "5"}, 2);
            Assert.AreEqual(3, result.Length);
            Assert.AreEqual(new[]{"1","2"}, result[0].Zeilen);
            Assert.AreEqual(new[]{"3","4"}, result[1].Zeilen);
            Assert.AreEqual(new[]{"5"}, result[2].Zeilen);
        }
    }
}