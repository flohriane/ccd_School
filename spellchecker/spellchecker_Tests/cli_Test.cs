using NUnit.Framework;
using spellchecker;

namespace spellchecker_Tests
{
    [TestFixture]
    class CLI_Test
    {
        [Test]
        public void Eingabe_testen()
        {
            var cli = new CLI(new[] { "a", "b", "c" });
            // was ist hier ein sinnvoller Test ???
        }
    }
}
