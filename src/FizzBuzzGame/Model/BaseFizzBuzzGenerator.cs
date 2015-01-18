using FizzBuzzGame.Presenter;

namespace FizzBuzzGame
{
    public class BaseFizzBuzzGenerator
    {
        private readonly FizzBuzz _fizzBuzz;
        private readonly ConsoleOutputWriter _consoleOutputWriter;

        public BaseFizzBuzzGenerator(FizzBuzz fizzBuzz, ConsoleOutputWriter consoleOutputWriter)
        {
            _fizzBuzz = fizzBuzz;
            _consoleOutputWriter = consoleOutputWriter;
        }

        public void Generate()
        {
            for (var index = 1; index <= 100; index++)
            {
                _consoleOutputWriter.Write(_fizzBuzz.Evaluate(index));
            }
        }
    }
}