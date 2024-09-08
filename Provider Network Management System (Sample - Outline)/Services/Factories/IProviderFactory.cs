using Provider_Network_Management_System__Sample___Outline_.Domain.Entities;

namespace Provider_Network_Management_System__Sample___Outline_.Services.Factories
{
    public interface IProviderFactory
    {
        Provider CreateProvider(string providerType);
    }
}
