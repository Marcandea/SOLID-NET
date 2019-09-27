using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.DependencyInversion.Principle
{
    public class NotificationP
    {
        private ICollection<IMessage> _messages;

        public NotificationP(ICollection<IMessage> messages)
        {
            this._messages = messages;
        }
        public void Send()
        {
            foreach (var message in _messages)
            {
                message.SendMessage();
            }
        }
    }
}
