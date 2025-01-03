namespace AdminDashboard.Patterns.Factory
{
    public class UserRole : IRole
    {
        public void DefinePermissions()
        {
            Console.WriteLine("User: Limited access to personal data.");
        }
    }
}
