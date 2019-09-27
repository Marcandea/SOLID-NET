using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.DependencyInversion.Principle
{
    public class SMSP : IMessage
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public void SendMessage()
        {
            //Send sms
        }
    }
}
