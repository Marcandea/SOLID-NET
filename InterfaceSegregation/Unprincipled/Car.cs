using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.InterfaceSegregation.Unprincipled
{
    public class Car: IVehicle
    {
        public void Drive()
        {
            //actions to drive a car
            Console.WriteLine("Driving a car");
        }

        public void Fly()
        {
            throw new NotImplementedException();
        }
    }
}
