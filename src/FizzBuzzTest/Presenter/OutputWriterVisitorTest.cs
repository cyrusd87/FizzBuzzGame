using FizzBuzzGame.Model;
using FizzBuzzGame.Presenter;
using Moq;
using NUnit.Framework;

namespace FizzBuzzTest.Presenter
{
    public class OutputWriterVisitorTest
    {

        private MockRepository _repository;
        private Mock<IOutputWriterVisitor> _consoleWriter;

        [SetUp]
        public void SetUp()
        {
            _repository = new MockRepository(MockBehavior.Strict);
            _consoleWriter = _repository.Create<IOutputWriterVisitor>();
        }

        [Test]
        public void ShouldPrintFizzWhenInputIsThree()
        {
            var isWriteMethodCalled = false;
            var fizzFormat = new FizzFormat();

            _consoleWriter.Setup(x => x.Visit(fizzFormat)).Callback(() => isWriteMethodCalled = true);

            var writer = _consoleWriter.Object;

            writer.Visit(fizzFormat);

           Assert.IsTrue(isWriteMethodCalled);
        }

        [Test]
        public void ShouldPrintBuzzWhenInputIsFive()
        {
            var isWriteMethodCalled = false;

            var fizzFormat = new BuzzFormat();
            _consoleWriter.Setup(x => x.Visit(fizzFormat)).Callback(() => isWriteMethodCalled = true);

            var writer = _consoleWriter.Object;
            writer.Visit(fizzFormat);

            Assert.IsTrue(isWriteMethodCalled);
        }

        [Test]
        public void ShouldPrintFizzBuzzWhenInputIsMultipleOfThreeAndFive()
        {
            var isWriteMethodCalled = false;

            var fizzFormat = new FizzBuzzFormat();;
            _consoleWriter.Setup(x => x.Visit(fizzFormat)).Callback(() => isWriteMethodCalled = true);

            var writer = _consoleWriter.Object;
            writer.Visit(fizzFormat);

            Assert.IsTrue(isWriteMethodCalled);
        }

        [Test]
        public void ShouldPrintNumber()
        {
            var isWriteMethodCalled = false;

            var fizzFormat = new NumberFormat(1);
            _consoleWriter.Setup(x => x.Visit(fizzFormat)).Callback(() => isWriteMethodCalled = true);

            var writer = _consoleWriter.Object;
            writer.Visit(fizzFormat);

            Assert.IsTrue(isWriteMethodCalled);
        }

        [TearDown]
        public void VerifyAll()
        {
            _repository.VerifyAll();
        }

    }
}
