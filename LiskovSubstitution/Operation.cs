using SOLID.Principle;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Unprincipled
{
    class Operation
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 5, 7, 9, 8, 1, 6, 4 };
            /** Without Principle **/
            Console.WriteLine("Unprincipled:");
            SumCalculator sum = new SumCalculator(numbers);
            Console.WriteLine($"The sum of all the numbers: {sum.Calculate()}");


            EvenNumbersSumCalculator evenSum = new EvenNumbersSumCalculator(numbers);
            Console.WriteLine($"The sum of all the even numbers: {evenSum.Calculate()}");

            //Executes superior method, the result should be 18 but return 40
            SumCalculator evenSum2 = new EvenNumbersSumCalculator(numbers);
            Console.WriteLine($"The sum of all the even numbers: {evenSum2.Calculate()}");
            Console.WriteLine();
            /** End **/

            /** With Liskov Substitution Principle **/
            Console.WriteLine("Principled:");
            Calculator sumP = new SumCalculatorP(numbers);
            Console.WriteLine($"The sum of all the numbers: {sumP.Calculate()}");

            Calculator evenSumP = new EvenNumbersSumCalculatorP(numbers);
            Console.WriteLine($"The sum of all the even numbers: {evenSumP.Calculate()}");
            /** End **/

        }
    }
}
