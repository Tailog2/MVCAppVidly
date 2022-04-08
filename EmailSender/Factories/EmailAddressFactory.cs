using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EmailSenderLibrary.Factories
{
    internal class EmailAddressFactory
    {
        public static MailAddress CreateEmailAddress(string emailAddress, string? ownerName)
        {
            return new MailAddress(emailAddress, ownerName);
        }
    }
}
