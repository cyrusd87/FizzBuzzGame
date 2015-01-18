using System.Globalization;
using FizzBuzzGame.Presenter;

namespace FizzBuzzGame.Model
{
    public class NumberFormat : IFizzBuzzFormat
    {
        public NumberFormat(int value)
        {
            FormatValue = value.ToString(CultureInfo.InvariantCulture);
        }

        public string FormatValue { get; private set; }
        public string ForegroundColor { get { return "White"; } }

        public void Accept(IOutputWriterVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

 }