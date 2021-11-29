using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XUnitTest.App
{
    public class Calculator
    {
        private ICalculatorService _calculatorService { get; set; }

        public Calculator(ICalculatorService calculatorService)
        {
            this._calculatorService = calculatorService;
        }
        public int Add(int a, int b)
        {
            return _calculatorService.Add(a, b);
        }
        public int Multiple(int a, int b)
        {
            return _calculatorService.Multiple(a, b);
        }
    }
}
