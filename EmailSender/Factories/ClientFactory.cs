using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EmailSenderLibrary.Factories
{
    internal class ClientFactory
    {
        public static SmtpClient CreateGmailClient(string sender, string senderPassword, string emailProvider)
        {
            SmtpClient client = new SmtpClient()
            {
                Host = emailProvider,
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential()
                {
                    UserName = sender,
                    Password = senderPassword
                }
            };
            return client;
        }
    }
}
