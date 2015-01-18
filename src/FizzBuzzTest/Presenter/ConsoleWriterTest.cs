using FizzBuzzGame.Model;
using FizzBuzzGame.Presenter;
using Moq;
using NUnit.Framework;

namespace FizzBuzzTest.Presenter
{
    public class ConsoleWriterTest
    {

        private MockRepository _repository;
        private Mock<IOutputWriter> _consoleWriter;

        [SetUp]
        public void SetUp()
        {
            _repository = new MockRepository(MockBehavior.Strict);
            _consoleWriter = _repository.Create<IOutputWriter>();
        }

        [Test]
        public void ShouldPrintFizzWhenInputIsThree()
        {
            var isWriteMethodCalled = false;
            var fizzFormat = new FizzFormat();

            _consoleWriter.Setup(x => x.Write(fizzFormat,"Green")).Callback(() => isWriteMethodCalled = true);

            var writer = _consoleWriter.Object;

            writer.Write(fizzFormat,"Green");

            Assert.IsTrue(isWriteMethodCalled);
        }

        [Test]
        public void ShouldPrintBuzzWhenInputIsFive()
        {
            var isWriteMethodCalled = false;

            var fizzFormat = new BuzzFormat();
            _consoleWriter.Setup(x => x.Write(fizzFormat,"Blue")).Callback(() => isWriteMethodCalled = true);

            var writer = _consoleWriter.Object;
            writer.Write(fizzFormat,"Blue");

            Assert.IsTrue(isWriteMethodCalled);
        }

        [Test]
        public void ShouldPrintFizzBuzzWhenInputIsMultipleOfThreeAndFive()
        {
            var isWriteMethodCalled = false;

            var fizzFormat = new FizzBuzzFormat(); ;
            _consoleWriter.Setup(x => x.Write(fizzFormat,"Red")).Callback(() => isWriteMethodCalled = true);

            var writer = _consoleWriter.Object;
            writer.Write(fizzFormat,"Red");

            Assert.IsTrue(isWriteMethodCalled);
        }

        [Test]
        public void ShouldPrintNumber()
        {
            var isWriteMethodCalled = false;

            var fizzFormat = new NumberFormat(1);
            _consoleWriter.Setup(x => x.Write(fizzFormat,"White")).Callback(() => isWriteMethodCalled = true);

            var writer = _consoleWriter.Object;
            writer.Write(fizzFormat,"White");

            Assert.IsTrue(isWriteMethodCalled);
        }

        [TearDown]
        public void VerifyAll()
        {
            _repository.VerifyAll();
        }
    }
}
