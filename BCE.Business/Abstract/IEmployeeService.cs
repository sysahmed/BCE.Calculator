using BCE.Core.Utilities.Results;
using BCE.Entities.Concrete;

namespace BCE.Business.Abstract
{
    public interface IEmployeeService
    {
        IDataResult<Employees> Add(Employees employee);
        IDataResult<Employees> CharitySpent(Employees employee);
        IDataResult<Employees> GetSocialContributions(Employees employee);
        IDataResult<Employees> GetEstimateVat(Employees employee);

    }
}
