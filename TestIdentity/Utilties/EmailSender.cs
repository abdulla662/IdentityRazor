using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net.Mail;
using System.Net;

namespace TestIdentity.Utilties
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string message)
        {
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("worldtroidgaming@gmail.com", "yjca ewrj qdxn zqiu")
            };

            return client.SendMailAsync(
                new MailMessage(from: "worldtroidgaming@gmail.com",
                                to: email,
                                subject,
                                message
                                )
                { 
                IsBodyHtml = true
                }
                
                );
        }
    }
}
