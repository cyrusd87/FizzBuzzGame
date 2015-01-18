using FizzBuzzGame.Presenter;

namespace FizzBuzzGame.Model
{
    public interface IFizzBuzzFormat
    {
        string FormatValue { get; }
        string ForegroundColor { get; }

        void Accept(IOutputWriterVisitor visitor);
    }
}