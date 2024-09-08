using Provider_Network_Management_System__Sample___Outline_.Data.Repositories;
using Provider_Network_Management_System__Sample___Outline_.Domain.Entities;
using Provider_Network_Management_System__Sample___Outline_.Services.Observers;

namespace Provider_Network_Management_System__Sample___Outline_.Services
{
    public class ProviderService
    {
        private readonly IProviderRepository _repository;
        private readonly List<IObserver> _observers;

        public ProviderService(IProviderRepository repository)
        {
            _repository = repository;
            _observers = new List<IObserver>();
        }

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public async Task AddProviderAsync(Provider provider)
        {
            await _repository.AddProviderAsync(provider);
            NotifyObservers($"New provider {provider.Name} added.");
        }
        public async Task<IEnumerable<Provider>> GetAllProvidersAsync()
        {
            return await _repository.GetAllProvidersAsync();
        }

        private void NotifyObservers(string message)
        {
            foreach (var observer in _observers)
            {
                observer.Notify(message);
            }
        }
    }
}

