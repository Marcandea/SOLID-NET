using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OpenClosed.Principle
{
    public class PremiumMemberShip : MemberShip
    {
        public override decimal CalculatePrice(decimal price)
        {
            return price * (1 - 0.1M);
        }
    }
}
