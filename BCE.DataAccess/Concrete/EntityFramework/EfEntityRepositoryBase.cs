using BCE.Core.Abstract;
using BCE.Core.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace BCE.DataAccess.Concrete.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
    where TEntity : class, IEntities, new()
    where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            
        }

    }
}
