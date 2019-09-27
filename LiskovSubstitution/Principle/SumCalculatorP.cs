using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOLID.Principle
{
    public class SumCalculatorP : Calculator
    {
        public SumCalculatorP(int[] numbers)
            : base(numbers)
        {
        }

        public override int Calculate() => _numbers.Sum();
    }
}
