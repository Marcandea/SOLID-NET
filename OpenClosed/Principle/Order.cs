using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OpenClosed.Principle
{
    public class Order
    {
        public decimal CalculatePrice(decimal price, CustomerP customer)
        {
            return customer.MemberShipTypeP.CalculatePrice(price);
        }
    }
}
