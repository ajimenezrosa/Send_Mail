using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace MailSendingCode
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();

                message.From = new MailAddress("abc@gmail.com");
                message.To.Add(new MailAddress("pqr@yahoo.com"));  // I don't know how to grab the user mail id here. please check.
                message.Subject = "Your Verification Code For Busy Executive";
                message.Body = "Hello, " +
                               "------------------------------------------------------------------------------" +
                               "thanks ~ Ruddra Arnab";

                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("abc@gmail.com", "123456##");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);

            }
            catch (Exception ex)
            {
                throw ex;
            }

      
            
        }
    }
}
