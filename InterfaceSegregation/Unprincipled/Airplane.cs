using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.InterfaceSegregation.Unprincipled
{
    public class Airplane : IVehicle
    {
        public void Drive()
        {
            throw new NotImplementedException();
        }

        public void Fly()
        {
            //actions to fly a plane
            Console.WriteLine("Flying a plane");
        }
    }
}
