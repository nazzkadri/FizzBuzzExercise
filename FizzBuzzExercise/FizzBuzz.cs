using System;

namespace FizzBuzzExercise
{
    public class FizzBuzz
    {
        public String displayNumbers(int number)
        {
            if(number % 3 == 0 && number % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if(number % 3 == 0) { return "Fizz"; }
            else if(number % 5 == 0) { return "Buzz"; }
            else { return number.ToString(); }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
