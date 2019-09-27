using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOLID.Principle
{
    public class EvenNumbersSumCalculatorP : Calculator
    {
        public EvenNumbersSumCalculatorP(int[] numbers)
           : base(numbers)
        {
        }

        public override int Calculate() => _numbers.Where(x => x % 2 == 0).Sum();
    }
}
