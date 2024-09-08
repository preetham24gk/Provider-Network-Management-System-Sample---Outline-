using Provider_Network_Management_System__Sample___Outline_.Domain.Entities;

namespace Provider_Network_Management_System__Sample___Outline_.Data.Repositories
{
    public interface IProviderRepository
    {
        Task<IEnumerable<Provider>> GetAllProvidersAsync();
        Task<Provider> GetProviderByIdAsync(int providerId);
        Task AddProviderAsync(Provider provider);
        Task<IEnumerable<Provider>> FilterProviders(string specialty, string location);
    }
}
