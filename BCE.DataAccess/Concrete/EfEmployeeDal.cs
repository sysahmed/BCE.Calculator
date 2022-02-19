using BCE.DataAccess.Abstract;
using BCE.DataAccess.Concrete.EntityFramework;
using BCE.DataAccess.Concrete.EntityFramework.Context;
using BCE.Entities.Concrete;

namespace BCE.DataAccess.Concrete
{
    public class EfEmployeeDal : EfEntityRepositoryBase<Employees,MyDbContext>, IEmployeeDal
    {

    }
}
