using System.Net;
using System.Net.Mail;

namespace Companies.Adm.Panel.Server.Services
{
    public class EmailSender : IEmailSender
    {
        public async Task SendEmailAsync(string toEmailAddress, string emailSubject, string emailMessageHtml)
        {

            var message = new MailMessage();
            message.To.Add(toEmailAddress);
            message.Subject = emailSubject;
            message.Body = emailMessageHtml;
            message.From = new MailAddress("desenvolvimento@SESsaude.com.br");

            using (var smtpClient = new SmtpClient("email-ssl.com.br", 587))
            {
                NetworkCredential MyCredentials = new NetworkCredential("desenvolvimento@SESsaude.com.br", "SESsaude@22");
                smtpClient.Credentials = MyCredentials;
                await smtpClient.SendMailAsync(message);
            }
        }

    }

    public interface IEmailSender
    {
        Task SendEmailAsync(string toEmailAddress, string emailSubject, string emailMessageHtml);
    }
}

