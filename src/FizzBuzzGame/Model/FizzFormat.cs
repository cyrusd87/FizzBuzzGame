using FizzBuzzGame.Presenter;

namespace FizzBuzzGame.Model
{
    public class FizzFormat : IFizzBuzzFormat
    {
        public string FormatValue { get { return "Fizz"; } }
        public string ForegroundColor { get { return "Green"; } }

        public void Accept(IOutputWriterVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}