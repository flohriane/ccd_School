using FizzBuzz;
using NUnit.Framework;

namespace FizzBuzz_tests
{
    [TestFixture]
    public class Woerterbuch_tests
    {
        [Test, Category ("Akzeptanztest")]
        public void Fizzbuzz_übersetzen()
        {
            var result = Woerterbuch.Nach_FizzBuzz_übersetzen(15);
            Assert.AreEqual("1", result[1]);
            Assert.AreEqual("2", result[2]);
            Assert.AreEqual("Fizz", result[3]);
            Assert.AreEqual("4", result[4]);
            Assert.AreEqual("Buzz", result[5]);
            Assert.AreEqual("FizzBuzz", result[15]);
            Assert.AreEqual(15, result.Count);
        }
    }
}