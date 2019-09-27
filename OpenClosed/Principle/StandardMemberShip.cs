using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OpenClosed.Principle
{
    public class StandardMemberShip : MemberShip
    {
        public override decimal CalculatePrice(decimal price)
        {
            return price;
        }
    }
}
