using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EmailSenderLibrary.Factories
{
    internal class MessageFactory
    {
        public static MailMessage CreateTextMessage(MailAddress sender, MailAddress receiver, string subject, string body)
        {
            MailMessage message = new MailMessage()
            {
                From = sender,
                Subject = subject,
                Body = body
            };
            message.To.Add(receiver);
            return message;
        }

        public static MailMessage CreateHTMLMessage(MailAddress sender, MailAddress receiver, string subject, string body)
        {
            MailMessage message = new MailMessage()
            {
                From = sender,
                Subject = subject,
                Body = body,
                IsBodyHtml = true
            };
            message.To.Add(receiver);
            return message;
        }
    }
}
