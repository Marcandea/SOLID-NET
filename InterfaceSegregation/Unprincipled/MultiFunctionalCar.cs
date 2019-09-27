using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.InterfaceSegregation.Unprincipled
{
    public class MultiFunctionalCar: IVehicle
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
