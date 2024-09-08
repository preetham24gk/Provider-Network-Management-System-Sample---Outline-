using Provider_Network_Management_System__Sample___Outline_.Domain.Entities;

namespace Provider_Network_Management_System__Sample___Outline_.Services.Factories
{
    public class ProviderFactory : IProviderFactory
    {
        public Provider CreateProvider(string providerType)
        {
            switch (providerType)
            {
                case "Hospital":
                    return new Hospital();
                case "Clinic":
                    return new Clinic();
                default:
                    throw new ArgumentException("Invalid provider type.");
            }
        }
    }
}
