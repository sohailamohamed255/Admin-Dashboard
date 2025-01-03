namespace AdminDashboard.Patterns.Observer
{
    public class Logger : IObserver
    {
        public void Notify(string message)
        {
            Console.WriteLine($"[LOG]: {message}");
        }
    }
}
