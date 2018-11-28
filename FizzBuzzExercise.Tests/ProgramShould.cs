using System;
using Xunit;

namespace FizzBuzzExercise.Tests
{
    public class ProgramShould
    {
        [Fact]
        public void PrintFizzWhenPassedThree()
        {
            FizzBuzz sut = new FizzBuzz();
            Assert.Equal("Fizz", sut.displayNumbers(3));

        }

        [Fact]
        public void PrintBuzzWhenPassedFive()
        {
            FizzBuzz sut = new FizzBuzz();
            Assert.Equal("Buzz", sut.displayNumbers(5));

        }
        [Fact]
        public void PrintFizzBuzzWhenPassedFifteen()
        {
            FizzBuzz sut = new FizzBuzz();
            Assert.Equal("FizzBuzz", sut.displayNumbers(15));

        }

    }
}
