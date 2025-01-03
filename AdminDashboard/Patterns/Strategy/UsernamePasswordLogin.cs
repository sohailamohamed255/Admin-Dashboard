namespace AdminDashboard.Patterns.Strategy
{
    public class UsernamePasswordLogin : ILoginStrategy
    {
        public bool Login(string username, string password)
        {
            // Simple username/password authentication
            return username == "admin" && password == "password123";
        }
    }
}
