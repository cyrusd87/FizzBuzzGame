using FizzBuzzGame.Presenter;

namespace FizzBuzzGame
{
    public class ColorFizzBuzzGenerator 
    {
        private readonly FizzBuzz _fizzBuzz;
        private readonly OutputWriterVisitor _outputWriterVisitor;

        public ColorFizzBuzzGenerator(FizzBuzz fizzBuzz, OutputWriterVisitor outputWriterVisitor)
        {
            _fizzBuzz = fizzBuzz;
            _outputWriterVisitor = outputWriterVisitor;
         
        }

        public void Generate()
        {
            for (var index = 1; index <= 100; index++)
            {
                _fizzBuzz.Evaluate(index).Accept(_outputWriterVisitor);
            }
        }
    }
}