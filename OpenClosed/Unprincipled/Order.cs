using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OpenClosed
{
    public class Order
    {
        public decimal CalculatePrice(decimal price, Customer customer)
        {
            decimal result = 0;
            switch (customer.MemberShip)
            {
                case MemberShipType.Standard:
                    result = price;
                    break;
                case MemberShipType.Premium:
                    result = price * (1 - 0.1M);
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
