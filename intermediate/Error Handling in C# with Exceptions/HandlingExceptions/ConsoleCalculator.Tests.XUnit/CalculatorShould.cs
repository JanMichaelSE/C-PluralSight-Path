using System;
using Xunit;

namespace ConsoleCalculator.Tests.XUnit
{
    public class CalculatorShould
    {
        [Fact]
        public void ThrowWhenNotSupported()
        {
            var sut = new Calculator();

            // Assert
            Assert.Throws<CalculationNotSupportedException>(() => sut.Calculate(1, 1, "+"));

            //Assert.ThrowsException<CalculationException>(() => sut.Calculate(1, 1, "+"));

            var ex = Assert.Throws<CalculationNotSupportedException>(() => sut.Calculate(1, 1, "+"));

            Assert.Equal("+", ex.Operation);
        }
    }
}
