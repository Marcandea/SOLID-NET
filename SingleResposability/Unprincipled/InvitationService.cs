using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace SOLID.SingleResposability.Principle
{
    public class InvitationService
    {
        public void SendInvite(string email, string firstName, string lastName)
        {
            if (String.IsNullOrWhiteSpace(firstName) || String.IsNullOrWhiteSpace(lastName))
            {
                throw new Exception("Name is not valid!");
            }

            if (!email.Contains("@") || !email.Contains("."))
            {
                throw new Exception("Email is not valid!!");
            }
            SmtpClient client = new SmtpClient();
            client.Send(new MailMessage("mysite@nowhere.com", email) { Subject = "Please join me at my party!" });
        }
    }
}
