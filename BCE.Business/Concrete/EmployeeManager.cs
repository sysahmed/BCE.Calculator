using BCE.Business.Abstract;
using BCE.Core.Utilities.Results;
using BCE.DataAccess.Abstract;
using BCE.Entities.Concrete;

namespace BCE.Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        IEmployeeDal _employeeDal;

        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }

        #region MyGrudMethod
        public IDataResult<Employees> Add(Employees employee)
        {
             CharitySpent(employee);
             GetEstimateVat(employee);
             GetSocialContributions(employee);
            _employeeDal.Add(employee);
            return new DataResult<Employees>(employee, true);
        }
        #endregion

        #region IEmployeeService Members
        // First Method
        public IDataResult<Employees> CharitySpent(Employees employee)
        {
            employee.NetIncome = employee.GrossIncome;
            if (employee.CharitySpent > 0 )
            {
                if (employee.CharitySpent <= employee.GrossIncome / 10)
                {
                    decimal CharitySpen = employee.GrossIncome / 10;
                    employee.NetIncome = employee.NetIncome - CharitySpen;
                }
                else
                {
                    employee.NetIncome = employee.NetIncome - (employee.NetIncome/10);
                }
               
            }
           
            return new DataResult<Employees>(employee, true);
        }
        // Second Method
        public IDataResult<Employees> GetEstimateVat(Employees employee)
        {
            
            decimal vatVlues = employee.NetIncome - 1000;
            employee.EstimateVat = vatVlues / 10;
            return new DataResult<Employees>(employee, true);
        }
        // Final Method
        public IDataResult<Employees> GetSocialContributions(Employees employee)
        {
            if (employee.GrossIncome > 3000)
            {
                employee.SocialContributions = 2000*15/100;
            }
            else
            {
                employee.SocialContributions = employee.NetIncome * 15/100;
            }
            employee.TotalTax = employee.SocialContributions + employee.EstimateVat;
            employee.NetIncome = employee.GrossIncome - employee.TotalTax;
            return new DataResult<Employees>(employee, true);
        }
        #endregion
    }
}
