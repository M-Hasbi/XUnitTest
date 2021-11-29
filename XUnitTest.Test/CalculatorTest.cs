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
        public CalculatorTest()
        {
            this.calculator = new Calculator();
        }

        [Theory]
        [InlineData(5, 20, 25)]
        [InlineData(10, 15, 25)]
        public void Add_SimpleValues_ReturnsTotalValue(int a, int b, int expectedTotal)
        {
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
    }
}
