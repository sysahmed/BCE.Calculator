using BCE.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace BCE.DataAccess.Concrete.EntityFramework.Context
{
    public class MyDbContext : DbContext
    { 
        public DbSet<Employees> Employees { get; set; }
    }
}
