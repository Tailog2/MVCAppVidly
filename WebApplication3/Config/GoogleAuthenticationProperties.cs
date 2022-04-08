namespace WebApplication3.Config;

public class GoogleAuthenticationProperties
{
    private readonly IConfiguration _configuration;

    internal GoogleAuthenticationProperties(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public string GetGoogleClientId()
    {
        return _configuration.GetSection("GoogleAuthentication").GetSection("GoogleClientId").Value;
    }

    public string GetGoogleClientSecret()
    {
        return _configuration.GetSection("GoogleAuthentication").GetSection("GoogleClientSecret").Value;
    }
}