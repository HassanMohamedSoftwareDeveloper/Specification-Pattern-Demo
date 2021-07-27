using Core.Entities;

namespace Core.Specifications
{
    public class DeveloperWithAddressSpecification : BaseSpecifcation<Developer>
    {
        public DeveloperWithAddressSpecification(int years) : base(x => x.EstimatedIncome > years)
        {
            AddInclude(x => x.Address);
        }
    }
}
