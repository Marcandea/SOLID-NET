using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.DependencyInversion.Unprincipled
{
    public class SMS
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public void SendSMS()
        {
            //Send sms
        }
    }
}
