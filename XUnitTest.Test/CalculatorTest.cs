﻿using System;
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
        [Fact]
        public void AddTest()
        {
            //Arrange --> initiliazing the required paramethers 

            int a = 5;
            int b = 20;


            //Act --> calling the method which is going to be tested
            var total = calculator.Add(a, b);

            //Assert --> the testing method
            Assert.Equal<int>(25, total);

        }
        [Theory]
        [InlineData(5, 20, 25)]
        [InlineData(10, 15, 25)]
        public void AddTest2(int a, int b, int expectedTotal)
        {
            var actualTotal = calculator.Add(a, b);
            Assert.Equal(expectedTotal, actualTotal);
        }
    }
}
