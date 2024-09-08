namespace Provider_Network_Management_System__Sample___Outline_.Domain.Entities
{
    public class Contract
    {
        public int ContractId { get; set; }
        public string ContractDetails { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ProviderId { get; set; } // Foreign key to Provider
        public Provider Provider { get; set; }
    }
}
