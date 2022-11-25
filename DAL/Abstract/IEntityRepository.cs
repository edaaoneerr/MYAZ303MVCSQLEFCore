using MVCSQLEFCore.Entities;
using System.Linq.Expressions;

namespace MVCSQLEFCore.DAL.Abstract
{
   
    public interface IEntityRepository<T>
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        public List<T> GetAll(Expression<Func<T, bool>> filter);
    }
}
