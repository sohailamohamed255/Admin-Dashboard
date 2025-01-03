namespace AdminDashboard.Patterns.Observer
{
    public class AdminActionNotifier
    {
        private readonly List<IObserver> _observers = new();

        public void AddObserver(IObserver observer) => _observers.Add(observer);

        public void NotifyObservers(string message)
        {
            foreach (var observer in _observers)
            {
                observer.Notify(message);
            }
        }
    }
}
