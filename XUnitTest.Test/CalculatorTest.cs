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
        [Fact]
        public void AddTest()
        {
            //Arrange --> initiliazing the required paramethers 

            int a = 5;
            int b = 20;
            var calculater = new Calculator();

            //Act --> calling the method which is going to be tested
            var total = calculater.Add(a, b);



            //Assert --> the testing method
            Assert.Equal<int>(25, total);
        }

    }
}
