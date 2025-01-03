namespace AdminDashboard.Patterns.Strategy
{
    public interface ILoginStrategy
    {
        bool Login(string username, string password);
    }
}
