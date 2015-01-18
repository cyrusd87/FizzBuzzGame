using FizzBuzzGame;
using NUnit.Framework;

namespace FizzBuzzTest
{
    public class FizzBuzzTest
    {
        private FizzBuzz _fizzBuzz;

        [SetUp]
        public void SetUp()
        {
            _fizzBuzz = new FizzBuzz();
        }

        [Test]
        public void ShouldReturnFizzIfInputIsThree()
        {
            Assert.AreEqual("Fizz", _fizzBuzz.Evaluate(3).FormatValue);
        }

        [Test]
        public void ShouldReturnBuzzIfInputIsFive()
        {
            Assert.AreEqual("Buzz", _fizzBuzz.Evaluate(5).FormatValue);
        }

        [Test]
        public void ShouldReturnFizzBuzzIfInputIsMultipleOfThreeAndFive()
        {
            Assert.AreEqual("FizzBuzz", _fizzBuzz.Evaluate(15).FormatValue);
        }

        [Test]
        public void ShouldReturnTheNumberIfInputIsNotMultipleOfThreeOrFive()
        {
            Assert.AreEqual("1", _fizzBuzz.Evaluate(1).FormatValue);
        }

        [TestCase(1, "1")]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        public void ShouldReturnTheRightOutputForEachInputValue(int input, string output)
        {
            Assert.AreEqual(output, _fizzBuzz.Evaluate(input).FormatValue);
        }


    }
}
