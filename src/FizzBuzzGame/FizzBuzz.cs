using FizzBuzzGame.Model;

namespace FizzBuzzGame
{
    public class FizzBuzz
    {
        public IFizzBuzzFormat Evaluate(int value)
        {
            IFizzBuzzFormat result;

            if (IsMultipleOfThreeAndFive(value)) result = new FizzBuzzFormat();

            else if (IsMultipleOfThree(value))
                result = new FizzFormat();

            else if (IsMultipleOfFive(value))
                result = new BuzzFormat();

            else result = new NumberFormat(value);

            return result;
        }

        private bool IsMultipleOfThree(int value)
        {
            return value%3 == 0;
        }

        private bool IsMultipleOfFive(int value)
        {
            return value%5 == 0;
        }

        private bool IsMultipleOfThreeAndFive(int value)
        {
            return IsMultipleOfThree(value) && IsMultipleOfFive(value);
        }


    }
    
}