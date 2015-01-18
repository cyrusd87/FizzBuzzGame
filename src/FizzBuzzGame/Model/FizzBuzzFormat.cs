using FizzBuzzGame.Presenter;

namespace FizzBuzzGame.Model
{
    public class FizzBuzzFormat : IFizzBuzzFormat
    {
        public string FormatValue { get { return "FizzBuzz"; } }

        public string ForegroundColor { get { return "Red"; } }

        public void Accept(IOutputWriterVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}