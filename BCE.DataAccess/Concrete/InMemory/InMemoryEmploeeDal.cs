using BCE.DataAccess.Abstract;
using BCE.Entities.Concrete;
using System.Collections.Generic;

namespace BCE.DataAccess.Concrete.InMemory
{
    public class InMemoryEmploeeDal: IEmployeeDal
    {     
        List<Employees> _employeesList;
        Employees _employees;
        public InMemoryEmploeeDal(Employees employees)
        {
            _employees=employees;
            _employeesList = new List<Employees>();
        }
        public void Add(Employees employee)
        {
            _employeesList.Add(employee);
        }

   
    }
}
