using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.DependencyInversion.Principle
{
    public class EmailP : IMessage
    {
        public string ToAddress { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public void SendMessage()
        {
            //Send email
        }
    }
}
