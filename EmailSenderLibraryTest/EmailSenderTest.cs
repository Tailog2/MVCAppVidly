using EmailSenderLibrary;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Xunit;
using static EmailSenderLibrary.EmailSender;

namespace EmailSenderLibraryTest
{
    public class EmailSenderTest
    {
        IEmailSender emailSender;
        string subject = "You received a test email!";
        string text = "It is body of the test email!";
        string recieverEmail = "nedra.tailog@gmail.com";
        string senderEmail = "levsamson.work@gmail.com";
        string senderPassword = "12345|Samson";

        [Fact]
        [ExpectedException(typeof(EmailWasNotSendedExeption))]
        public void SendEmail_NoErrorOccurredAndEmailWasSended()
        {
            // Arrange
            emailSender = new VidlyEmailSender();

            // Act
            try
            {
                emailSender.SendEmailAsync(recieverEmail, subject, text);
            }
            catch (EmailWasNotSendedExeption e)
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.Fail();
            }
            // Assert       
        }
        public class VidlyEmailSender : EmailSender
        {
            public override string SenderEmail { get; set; } = "levsamson.work@gmail.com";
            public override string SenderPassword { get; set; } = "12345|Samson";
            public override string? SenderName { get; set; } = "Vidly.com";
            public override string? ReceiverName { get; set; } = null;
            public override string? Token { get; set; } = null;
            public override string EmailProvider { get; set; } = "smtp.gmail.com";
        }
    }
}