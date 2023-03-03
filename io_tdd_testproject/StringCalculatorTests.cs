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
    }
}