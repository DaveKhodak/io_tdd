using io_tdd_cl;

namespace io_tdd_testproject
{
    public class EmptyStringZeroTest
    {
        StringCalculator calculator;
        public EmptyStringZeroTest()
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