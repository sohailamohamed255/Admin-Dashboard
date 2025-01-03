namespace AdminDashboard.Patterns.Factory
{
    public class AdminRole : IRole
    {
        public void DefinePermissions()
        {
            Console.WriteLine("Admin: Full access to all features.");
        }
    }
}
