using io_tdd_cl;
using System;

namespace io_tdd_testproject
{
    public class StringCalculatorTests
    {
        StringCalculator calculator;
        public StringCalculatorTests()
        {
            calculator = new StringCalculator();
        }
        
        [Fact]
        public void WhenEmptyStringProvided_ItShouldReturnZero()
        {
            int result, expected = 0;

            result = calculator.Add("");

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("2", 2)]
        [InlineData("10", 10)]
        public void WhenSingleNumberProvided_ItShouldReturnThisNumber(string input, int expected)
        {
            int result = calculator.Add(input);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("2, 10", 12)]
        [InlineData("3,5", 8)]
        public void WhenTwoNumberCommaSeparatedProvided_ItShouldReturnSumOfTheseNumbers(string input, int expected)
        {
            int result = calculator.Add(input);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("2\n10", 12)]
        [InlineData("3\n5", 8)]
        public void WhenTwoNumberNewLineSeparatedProvided_ItShouldReturnSumOfTheseNumbers(string input, int expected)
        {
            int result = calculator.Add(input);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("2\n10,3", 15)]
        [InlineData("3\n5,4", 12)]
        public void WhenThreeNumbersNewLineOrCommaSeparatedProvided_ItShouldReturnSumOfTheseNumbers(string input, int expected)
        {
            int result = calculator.Add(input);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("-22\n10")]
        [InlineData("-3\n5")]
        public void WhenNegativeNumberProvided_ItShouldReturnArgumentOutOfRangeException(string input)
        {
            var expected = new ArgumentOutOfRangeException();
            try
            {
                calculator.Add(input);
            }
            catch(Exception e)
            {
                Assert.Equal(expected, e);
            }
        }

        [Theory]
        [InlineData("1\n2,1001", 3)]
        [InlineData("3\n5,10000", 8)]
        public void WhenGreaterThan1000Provided_ItShouldReturnSumWithoutThisNumber(string input, int expected)
        {
            int result = calculator.Add(input);

            Assert.Equal(expected, result);
        }
    }
}