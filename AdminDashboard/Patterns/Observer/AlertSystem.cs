namespace AdminDashboard.Patterns.Observer
{
    public class AlertSystem : IObserver
    {
        public void Notify(string message)
        {
            Console.WriteLine($"[ALERT]: {message}");
        }
    }
}
