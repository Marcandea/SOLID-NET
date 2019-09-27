using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.InterfaceSegregation.Principle
{
    public class AirplaneP : IAirplane
    {
        public void Fly()
        {
            //actions to fly a plane
            Console.WriteLine("Flying a plane");
        }
    }
}
