using EmailSenderLibrary;
using WebApplication3.Config;

namespace WebApplication3.EmailHandlers
{
    public sealed class VidlyEmailSender : EmailSender
    {
        public static IConfiguration Configuration = null!;
        public ConfigHelper ConfigHelper;

        public override string SenderEmail { get; set; }
        public override string SenderPassword { get; set; } 
        public override string? SenderName { get; set; } 
        public override string EmailProvider { get; set; }
        public override string? ReceiverName { get; set; } = null;
        public override string? Token { get; set; } = null;

        public VidlyEmailSender()
        {
            ConfigHelper = new ConfigHelper(Configuration);
            SenderEmail = ConfigHelper.GoogleEmailServer.GetSenderEmail();
            SenderPassword = ConfigHelper.GoogleEmailServer.GetSenderPassword();
            SenderName = ConfigHelper.GoogleEmailServer.GetSenderName();
            EmailProvider = ConfigHelper.GoogleEmailServer.GetEmailProvider();
        }
    }
}
