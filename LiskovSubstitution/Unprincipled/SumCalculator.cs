using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOLID.Unprincipled
{
    public class SumCalculator
    {
        protected readonly int[] _numbers;

        public SumCalculator(int[] numbers)
        {
            _numbers = numbers;
        }

        public int Calculate() => _numbers.Sum();
    }
}
