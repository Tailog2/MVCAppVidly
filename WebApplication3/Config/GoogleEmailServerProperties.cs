namespace WebApplication3.Config;

public class GoogleEmailServerProperties
{
    private readonly IConfiguration _configuration;

    internal GoogleEmailServerProperties(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public string GetSenderEmail()
    {
        return _configuration.GetSection("GoogleEmailServer").GetSection("SenderEmail").Value;
    }

    public string GetSenderPassword()
    {
        return _configuration.GetSection("GoogleEmailServer").GetSection("SenderPassword").Value;
    }

    public string GetSenderName()
    {
        return _configuration.GetSection("GoogleEmailServer").GetSection("SenderName").Value;
    }
    public string GetEmailProvider()
    {
        return _configuration.GetSection("GoogleEmailServer").GetSection("EmailProvider").Value;
    }
}