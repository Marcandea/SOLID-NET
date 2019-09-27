using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.InterfaceSegregation.Principle
{
    public class CarP : ICar
    {
        public void Drive()
        {
            //actions to drive a car
            Console.WriteLine("Driving a car");
        }
    }
}
