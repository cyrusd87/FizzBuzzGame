using System;
using FizzBuzzGame.Presenter;

namespace FizzBuzzGame
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowInstructions();
            var input = Console.ReadLine();
            
            while (input != "q")
            {
                switch (input)
                {
                    case "a": 
                        new BaseFizzBuzzGenerator(new FizzBuzz(), new ConsoleOutputWriter()).Generate();
                        break;
                    case "b":
                        new ColorFizzBuzzGenerator(new FizzBuzz(), new OutputWriterVisitor(new ConsoleOutputWriter())).Generate();
                        break;
                    case "c" :
                        new FilteredFizzBuzzGenerator(new FizzBuzz(), new OutputWriterVisitorDecorator(new OutputWriterVisitor(new ConsoleOutputWriter()), new TwitterOutputWriter())).Generate();
                        break;
                    default:
                        break;

                }
                
                
                ShowInstructions();
                input = Console.ReadLine();
            }

        }

        private static void ShowInstructions()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n\n\n********** FizzBuzz Game **********");
            Console.WriteLine("Digit a to see FizzBuzz Result");
            Console.WriteLine("Digit b to see FizzBuzz Result with different colors");
            Console.WriteLine("Digit c to filter only Fizz, Buzz and FizzBuzz");
            Console.WriteLine("Digit q to exit");
        }
    }
}
