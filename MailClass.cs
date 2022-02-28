using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;



namespace MalamProject
{
    public class MailClass
    {
        public string sendEEmail(string mailTo, string subject, string body)
        {
            try
            {
                var client = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Timeout = 30 * 1000,
                    Credentials = new NetworkCredential("checkjob.check123@gmail.com", "sssnnn334")
                };
                using (var msg = new MailMessage("checkjob.check123@gmail.com", mailTo))
                {
                    msg.Subject = subject;
                    msg.Body = body;
                    client.Send(msg);
                }

                return "success receiving email to " + mailTo;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return e.Message;
            }

        }

    }
}

