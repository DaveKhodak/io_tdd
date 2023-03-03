using io_tdd_cl;

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
    }
}