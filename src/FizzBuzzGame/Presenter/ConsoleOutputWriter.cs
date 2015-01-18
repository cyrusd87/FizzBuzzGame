using System;
using FizzBuzzGame.Model;

namespace FizzBuzzGame.Presenter
{
    public class ConsoleOutputWriter : IOutputWriter
    {
        public void Write(IFizzBuzzFormat input)
        {
            Console.WriteLine(input.FormatValue);
        }

        public void Write(IFizzBuzzFormat input, string foregroundColor)
        {
            ConsoleColor color;
            Enum.TryParse(foregroundColor, true, out color);
            Console.ForegroundColor = color;
            Write(input);
        }
    }
}