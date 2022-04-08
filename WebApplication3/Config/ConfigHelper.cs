namespace WebApplication3.Config
{
    public class ConfigHelper
    {

        public GoogleAuthenticationProperties GoogleAuthentication { get; private set; }
        public FacebookAuthenticationProperties FacebookAuthentication { get; private set; }
        public GoogleEmailServerProperties GoogleEmailServer { get; private set; }
        public DatabaseProperties Database { get; private set; }


        public ConfigHelper(IConfiguration configuration)
        {
            GoogleAuthentication = new GoogleAuthenticationProperties(configuration);
            FacebookAuthentication = new FacebookAuthenticationProperties(configuration);
            GoogleEmailServer = new GoogleEmailServerProperties(configuration);
            Database = new DatabaseProperties(configuration);
        }
    }
}
