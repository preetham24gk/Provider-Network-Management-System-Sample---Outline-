using System.Diagnostics.Contracts;

namespace Provider_Network_Management_System__Sample___Outline_.Domain.Entities
{
    public class Provider
    {
        public int ProviderId { get; set; }
        public string Name { get; set; }
        public string Specialty { get; set; }
        public string Location { get; set; }
        public List<Contract> Contracts { get; set; } // Relationships
    }
}
