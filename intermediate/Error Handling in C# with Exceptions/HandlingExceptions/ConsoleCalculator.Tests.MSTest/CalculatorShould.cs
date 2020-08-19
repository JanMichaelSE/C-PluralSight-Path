using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleCalculator.Tests.MSTest
{
    [TestClass]
    public class CalculatorShould
    {
        [TestMethod]
        public void WhenUnsupportedOperation()
        {
            // Assign
            var sut = new Calculator();


            // Act


            // Assert
            Assert.ThrowsException<CalculationNotSupportedException>(() => sut.Calculate(1,1,"+"));

            //Assert.ThrowsException<CalculationException>(() => sut.Calculate(1, 1, "+"));

            var ex = Assert.ThrowsException<CalculationNotSupportedException>(() => sut.Calculate(1, 1, "+"));

            Assert.AreEqual("+", ex.Operation);

        }
    }
}
