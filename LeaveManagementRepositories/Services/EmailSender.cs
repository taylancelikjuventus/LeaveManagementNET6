
using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net.Mail;

namespace LeaveManagementRepositories.Services
{
    public class EmailSender : IEmailSender
    {
        private readonly string stmpServer;
        private readonly int stmpPort;
        private readonly string fromEmailAddress;

        //Papercut Free SMTP server a email yollamak için gerekli parametreler.
        public EmailSender(string stmpServer , int stmpPort , string fromEmailAddress)
        {
            this.stmpServer = stmpServer;
            this.stmpPort = stmpPort;
            this.fromEmailAddress = fromEmailAddress;
        }


        //override etmemiz gereken method
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var msg = new MailMessage()
            {
                From = new MailAddress(fromEmailAddress),
                Subject = subject,
                Body = htmlMessage,
                IsBodyHtml = true,
                     
            };

            msg.To.Add(new MailAddress(email));

            /* İstedigimiz kadar kişiye gönderebiliirz email i 
            msg.To.Add(new MailAddress(email));
            msg.To.Add(new MailAddress(email));
            msg.To.Add(new MailAddress(email));
            msg.To.Add(new MailAddress(email));
            msg.To.Add(new MailAddress(email));
            */

            //sending email
            using ( var client = new SmtpClient() { Host = this.stmpServer , Port = this.stmpPort })
            {
                  client.Send(msg); 
            }


                return Task.CompletedTask;
        }
    }
}
