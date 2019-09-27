using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace SOLID.SingleResposability.Principle
{
    public class InvitationServiceP
    {
        UserNameService _userNameService;
        EmailService _emailService;

        public InvitationServiceP(UserNameService userNameService, EmailService emailService)
        {
            _userNameService = userNameService;
            _emailService = emailService;
        }
        public void SendInvite(string email, string firstName, string lastName)
        {
            _userNameService.Validate(firstName, lastName);
            _emailService.Validate(email);
            SmtpClient client = new SmtpClient();
            client.Send(new MailMessage("sitename@invites2you.com", email) { Subject = "Please join me at my party!" });
        }
    }
}
