namespace AdminDashboard.Patterns.Factory
{
    public class RoleFactory
    {
        public static IRole CreateRole(string roleType)
        {
            return roleType switch
            {
                "Admin" => new AdminRole(),
                "User" => new UserRole(),
                _ => throw new ArgumentException("Invalid role type")
            };
        }
    }
}
