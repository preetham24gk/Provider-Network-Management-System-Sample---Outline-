namespace Provider_Network_Management_System__Sample___Outline_.Services.Observers
{
    public class AdminObserver : IObserver
    {
        public void Notify(string message)
        {
            Console.WriteLine($"Admin notified: {message}");
        }
    }
}
