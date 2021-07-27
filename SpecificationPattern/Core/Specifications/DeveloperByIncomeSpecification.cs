using Core.Entities;

namespace Core.Specifications
{
    public class DeveloperByIncomeSpecification : BaseSpecifcation<Developer>
    {
        public DeveloperByIncomeSpecification()
        {
            AddOrderByDescending(x => x.EstimatedIncome);
        }
    }
}
