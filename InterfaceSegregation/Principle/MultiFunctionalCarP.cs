using SOLID.InterfaceSegregation.Principle;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.InterfaceSegregation
{
    public class MultiFunctionalCarP: ICar, IAirplane
    {
        public void Drive()
        {
            //actions to start driving car
            Console.WriteLine("Drive a multifunctional car");
        }

        public void Fly()
        {
            //actions to start flying
            Console.WriteLine("Fly a multifunctional car");
        }
    }
}
