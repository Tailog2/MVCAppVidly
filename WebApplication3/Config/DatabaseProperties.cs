using System.Configuration;

namespace WebApplication3.Config;

public class DatabaseProperties
{
    private readonly IConfiguration _configuration;

    internal DatabaseProperties(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public string GetDefaultConnectionString()
    {
        return _configuration.GetConnectionString("DefaultConnection");
    }
}