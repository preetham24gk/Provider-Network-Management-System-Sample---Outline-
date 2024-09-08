using Provider_Network_Management_System__Sample___Outline_.Domain.Entities;

namespace Provider_Network_Management_System__Sample___Outline_.Services.Strategies
{
    public class MandatoryContractStrategy : IContractStrategy
    {
        public bool ApproveContract(Contract contract)
        {
            // Business logic for mandatory contract approval
            return contract.StartDate < DateTime.Now;
        }
    }
}
