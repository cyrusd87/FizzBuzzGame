using FizzBuzzGame.Presenter;

namespace FizzBuzzGame.Model
{
    public class BuzzFormat : IFizzBuzzFormat
    {
        public string FormatValue { get { return "Buzz"; } }

        public string ForegroundColor { get { return "Blue"; } }

        public void Accept(IOutputWriterVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}