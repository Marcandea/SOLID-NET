using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.SingleResposability.Principle
{
    public class EmailService
    {
        public void Validate(string email)
        {
            if (!email.Contains("@") || !email.Contains("."))
            {
                throw new Exception("Email is not valid!!");
            }
        }
    }
}
