namespace WebApplication3.Config;

public class FacebookAuthenticationProperties
{
    private readonly IConfiguration _configuration;

    internal FacebookAuthenticationProperties(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public string GetFacebookAppId()
    {
        return _configuration.GetSection("FacebookAuthentication").GetSection("FacebookAppId").Value;
    }

    public string GetFacebookAppSecret()
    {
        return _configuration.GetSection("FacebookAuthentication").GetSection("FacebookAppSecret").Value;
    }
}