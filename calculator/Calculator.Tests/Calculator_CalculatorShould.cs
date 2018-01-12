using System;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorShould
    {
        private Calculator _calculator;

        public CalculatorShould()
        {
            _calculator = new Calculator();
        }

        [Theory]
        [InlineData(1,2,3)]
        [InlineData(2,2,4)]
        [InlineData(4,4,8)]
        [InlineData(5,5,10)]
        public void AddTwoIntegers(int a, int b, int c)
        {
            // Given this input to the method
            int sum = _calculator.Add(a, b);

            // We are asserting that the output should be this
            Assert.Equal(sum, c);
        }
    }
}
