using FizzBuzzGame.Model;

namespace FizzBuzzGame.Presenter
{
    
    public class OutputWriterVisitor : IOutputWriterVisitor
    {
        private readonly IOutputWriter _consoleWriter;

        public OutputWriterVisitor(IOutputWriter consoleWriter)
        {
            _consoleWriter = consoleWriter;
        }

        public void Visit(NumberFormat input)
        {
            _consoleWriter.Write(input, "White");
        }

        public void Visit(FizzFormat input)
        {
            _consoleWriter.Write(input,"Green");
        }

        public void Visit(BuzzFormat input)
        {
            _consoleWriter.Write(input,"Blue");
        }

        public void Visit(FizzBuzzFormat input)
        {
            _consoleWriter.Write(input,"Red");
        }
    }
}