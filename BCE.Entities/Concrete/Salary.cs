using BCE.Core.Abstract;

namespace BCE.Entities.Concrete
{
    public class Salary:IEntities
    {
        public decimal SocialContributions { get; set; } 
        public decimal EstimateVat { get; set; } 
        public decimal SocialTax { get; set; }
        public decimal TotalTax { get; set; }
        public decimal NetIncome { get; set; }
        public decimal CharitySpent { get; set; }

    }
}
