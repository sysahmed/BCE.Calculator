using BCE.Core.Abstract;

namespace BCE.Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntities, new()
    {
        void Add(T entity);
    }
}
