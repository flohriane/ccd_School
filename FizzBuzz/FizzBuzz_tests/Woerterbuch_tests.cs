using FizzBuzz;
using NUnit.Framework;

namespace FizzBuzz_tests
{
    [TestFixture]
    public class Woerterbuch_tests
    {
        [Test]
        public void Fizzbuzz_übersetzen()
        {
            var result = Woerterbuch.Nach_FizBuzz_übersetzen(5);
            Assert.AreEqual("1", result[1]);
            Assert.AreEqual("2", result[2]);
            Assert.AreEqual("Fizz", result[3]);
            Assert.AreEqual("4", result[4]);
            Assert.AreEqual("Buzz", result[5]);
            Assert.AreEqual(5, result.Count);
        }
    }
}