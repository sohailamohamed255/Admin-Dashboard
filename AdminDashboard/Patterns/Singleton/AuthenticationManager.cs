namespace AdminDashboard.Patterns.Singleton
{
    public class AuthenticationManager
    {
        private static readonly AuthenticationManager _instance = new AuthenticationManager();
        private static readonly object _lock = new();

        private AuthenticationManager() { }

        public static AuthenticationManager Instance => _instance;

        public bool ValidateToken(string token)
        {
            // Dummy token validation
            return token == "validToken";
        }
    }
}
