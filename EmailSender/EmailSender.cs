using EmailSenderLibrary.Factories;
using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EmailSenderLibrary
{
    public abstract class EmailSender : IEmailSender
    {
        public abstract string SenderEmail { get; set; }
        public abstract string SenderPassword { get; set; }
        public abstract string EmailProvider { get; set; }
        public abstract string? SenderName { get; set; }
        public abstract string? ReceiverName { get; set; }
        public abstract string? Token { get; set; }

        public EmailSender()
        {
        }

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            SmtpClient smtpClient = ClientFactory.CreateGmailClient(SenderEmail, SenderPassword, EmailProvider);

            MailAddress fromEmail = EmailAddressFactory.CreateEmailAddress(SenderEmail, SenderName);
            MailAddress toEmail = EmailAddressFactory.CreateEmailAddress(email, ReceiverName);

            MailMessage message = MessageFactory.CreateHTMLMessage(fromEmail, toEmail, subject, htmlMessage);

            smtpClient.SendCompleted += OnSendComplete;

            smtpClient.SendAsync(message, Token);

            return Task.CompletedTask;
        }

        private void OnSendComplete(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error is not null)    
            {
                throw new EmailWasNotSendedExeption("An error has occurred during on email sending");
            }
        }

        public class EmailWasNotSendedExeption : Exception
        {
            public EmailWasNotSendedExeption(string message)
            {
                Console.WriteLine(message);
            }
        }  
    }
}
