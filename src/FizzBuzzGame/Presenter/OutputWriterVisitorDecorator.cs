using FizzBuzzGame.Model;

namespace FizzBuzzGame.Presenter
{
    public class OutputWriterVisitorDecorator : IOutputWriterVisitor
    {
        private readonly IOutputWriterVisitor _visitor;
        private readonly IOutputWriter _twitterWriter;

        public OutputWriterVisitorDecorator(IOutputWriterVisitor visitor, IOutputWriter twitterWriter)
        {
            _visitor = visitor;
            _twitterWriter = twitterWriter;
        }

        public void Visit(NumberFormat input)
        {
            _twitterWriter.Write(input);
        }

        public void Visit(FizzFormat input)
        {
            _visitor.Visit(input);
        }

        public void Visit(BuzzFormat input)
        {
            _visitor.Visit(input);
        }

        public void Visit(FizzBuzzFormat input)
        {

            _visitor.Visit(input);
        }

    }
}