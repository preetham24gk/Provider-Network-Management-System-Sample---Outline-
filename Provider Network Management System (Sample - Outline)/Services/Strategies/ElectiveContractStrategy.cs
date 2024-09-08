using Provider_Network_Management_System__Sample___Outline_.Domain.Entities;

namespace Provider_Network_Management_System__Sample___Outline_.Services.Strategies
{
    public class ElectiveContractStrategy : IContractStrategy
    {
        public bool ApproveContract(Contract contract)
        {
            // Different rule for elective contracts
            return contract.StartDate > DateTime.Now && contract.EndDate < DateTime.Now.AddYears(1);
        }
    }
}
