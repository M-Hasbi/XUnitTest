using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using XUnitTest.App;

namespace XUnitTest.Test
{
    public class CalculatorTest
    {
        public Calculator calculator { get; set; }
        public Mock<ICalculatorService> mymock { get; set; }
        public CalculatorTest()
        {
            mymock = new Mock<ICalculatorService>();
            this.calculator = new Calculator(mymock.Object);
        }

        [Theory]
        [InlineData(5, 20, 25)]
        [InlineData(10, 15, 25)]
        public void Add_SimpleValues_ReturnsTotalValue(int a, int b, int expectedTotal)
        {

            mymock.Setup(x => x.Add(a, b)).Returns(expectedTotal);

            var actualTotal = calculator.Add(a, b);
            Assert.Equal(expectedTotal, actualTotal);
        }

        [Theory]
        [InlineData(0, 20, 0)]
        [InlineData(10, 0, 0)]
        public void Add_ZeroValues_ReturnsZeroValue(int a, int b, int expectedTotal)
        {
            var actualTotal = calculator.Add(a, b);
            Assert.Equal(expectedTotal, actualTotal);
        }
        [Theory]
        [InlineData(5, 3, 15)]
        [InlineData(0, 5, 0)]
        public void Multiple_SimpleValues_ReturnsValue(int a, int b, int expectedValue)
        {
            mymock.Setup(x => x.Multiple(a, b)).Returns(expectedValue);
            var actualValue = calculator.Multiple(a, b);
            Assert.Equal(expectedValue,actualValue);
        }
    }
}
