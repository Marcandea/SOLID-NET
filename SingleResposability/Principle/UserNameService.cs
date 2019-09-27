using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.SingleResposability.Principle
{
    public class UserNameService
    {
        public void Validate(string firstName, string lastName)
        {
            if (String.IsNullOrWhiteSpace(firstName) || String.IsNullOrWhiteSpace(lastName))
            {
                throw new Exception("The name is invalid!");
            }
        }
    }
}
