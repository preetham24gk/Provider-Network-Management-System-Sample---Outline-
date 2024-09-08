using Provider_Network_Management_System__Sample___Outline_.Domain.Entities;

namespace Provider_Network_Management_System__Sample___Outline_.Services.Strategies
{
    public interface IContractStrategy
    {
        bool ApproveContract(Contract contract);
    }
}
