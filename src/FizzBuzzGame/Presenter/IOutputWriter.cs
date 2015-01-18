using FizzBuzzGame.Model;

namespace FizzBuzzGame.Presenter
{
    public interface IOutputWriter
    {
        void Write(IFizzBuzzFormat input);
        void Write(IFizzBuzzFormat input,string foregroundColor);
    }
}