using FizzBuzzGame.Presenter;

namespace FizzBuzzGame
{
    public class FilteredFizzBuzzGenerator 
    {
        private readonly FizzBuzz _fizzBuzz;
        private readonly OutputWriterVisitorDecorator _outputWriterVisitorDecorator;

        public FilteredFizzBuzzGenerator(FizzBuzz fizzBuzz, OutputWriterVisitorDecorator outputWriterVisitorDecorator)
        {
            _fizzBuzz = fizzBuzz;
            _outputWriterVisitorDecorator = outputWriterVisitorDecorator;
        }

        public void Generate()
        {
            for (var index = 1; index <= 100; index++)
            {
                _fizzBuzz.Evaluate(index).Accept(_outputWriterVisitorDecorator);
            }
        }
    }
}