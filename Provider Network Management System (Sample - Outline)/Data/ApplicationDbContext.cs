using Microsoft.EntityFrameworkCore;
using Provider_Network_Management_System__Sample___Outline_.Domain.Entities;

namespace Provider_Network_Management_System__Sample___Outline_.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        // Define DbSets for your entities
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Contract> Contracts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Fluent API configurations can be added here if needed
            // Example: modelBuilder.Entity<Provider>().HasKey(p => p.ProviderId);
        }
    }
}
