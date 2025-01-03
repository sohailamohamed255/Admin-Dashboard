 namespace AdminDashboard.Patterns.Strategy
{
    public class OAuthLogin : ILoginStrategy
    {
        public bool Login(string username, string password)
        {
            // Dummy OAuth authentication
            return username == "oauthUser" && password == "oauthToken";
        }
    }
}
