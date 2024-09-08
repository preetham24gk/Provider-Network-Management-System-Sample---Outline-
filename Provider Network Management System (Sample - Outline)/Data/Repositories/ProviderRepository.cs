using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using Provider_Network_Management_System__Sample___Outline_.Domain.Entities;

namespace Provider_Network_Management_System__Sample___Outline_.Data.Repositories
{
    public class ProviderRepository : IProviderRepository
    {
        private readonly ApplicationDbContext _context;  // For SQL Server
        private readonly IMongoCollection<Provider> _mongoCollection; // For MongoDB

        public ProviderRepository(ApplicationDbContext context, IMongoClient mongoClient)
        {
            _context = context;
            _mongoCollection = mongoClient.GetDatabase("ProviderDB").GetCollection<Provider>("Providers");
        }

        // Fetch all providers from SQL Server
        public async Task<IEnumerable<Provider>> GetAllProvidersAsync()
        {
            // SQL Server retrieval using Entity Framework
            return await _context.Providers.ToListAsync();
        }
        // Fetch provider by ID from SQL Server
        public async Task<Provider> GetProviderByIdAsync(int providerId)
        {
            return await _context.Providers.FirstOrDefaultAsync(p => p.ProviderId == providerId);
        }
        // Fetch all providers from MongoDB (if needed)
        public async Task<IEnumerable<Provider>> GetAllProvidersFromMongoAsync()
        {
            // MongoDB retrieval
            return await _mongoCollection.Find(_ => true).ToListAsync();
        }

        // Method to add a provider (SQL Server)
        public async Task AddProviderAsync(Provider provider)
        {
            _context.Providers.Add(provider); // SQL Server Add
            await _context.SaveChangesAsync();
        }

        // Method to add a provider to MongoDB
        public async Task AddProviderToMongoAsync(Provider provider)
        {
            await _mongoCollection.InsertOneAsync(provider); // MongoDB Add
        }

        // Filter providers by specialty and location in both SQL and MongoDB
        public async Task<IEnumerable<Provider>> FilterProviders(string specialty, string location)
        {
            // SQL Server filtering
            var sqlFiltered = await _context.Providers
                .Where(p => p.Specialty == specialty && p.Location == location)
                .ToListAsync();

            // MongoDB filtering
            var mongoFiltered = await _mongoCollection
                .Find(p => p.Specialty == specialty && p.Location == location)
                .ToListAsync();

            // Concatenate both results
            return sqlFiltered.Concat(mongoFiltered);
        }
    }
}
