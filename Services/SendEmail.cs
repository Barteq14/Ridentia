using Microsoft.Extensions.Configuration;
using System.Net.Mail;
using System.Text;
using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace Gra_przegladarkowa.Services
{
    public class SendMail
    {

        public void SendEmail(string to, string subject, string msg)
        {
           
          
                


            var fromAddress = new MailAddress("ridentiagame@gmail.com", "Ridentia");
            var toAddress = new MailAddress(to, "Nowy użytkownik");
            const string fromPassword = "Complex.Ridentia.123";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = msg
            })
            {
                smtp.Send(message);
            }


        }
    }
}