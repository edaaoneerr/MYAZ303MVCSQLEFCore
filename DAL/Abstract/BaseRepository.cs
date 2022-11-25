using Microsoft.EntityFrameworkCore;
using MVCSQLEFCore.DAL.Concrete.EF;
using System.Linq.Expressions;

namespace MVCSQLEFCore.DAL.Abstract
{
    public interface BaseRepository<T, TContext> : IEntityRepository<T>
        where T : class, new()
        where TContext : DbContext, new()
    {
        public void Add(T entity)
        {
            using (var _context = new TContext())
            {
                _context.Entry(entity).State = EntityState.Added;
                _context.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (var _context = new TContext())
            {
                _context.Entry(entity).State = EntityState.Deleted;
                _context.SaveChanges();
            }
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter)
        {
            using (var _context = new TContext())
            {
                return filter == null ?
                    _context.Set<T>().ToList() :
                    _context.Set<T>().Where(filter).ToList();
            }
        }

        public void Update(T entity)
        {
            using (var _context = new TContext())
            {
                _context.Entry(entity).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }

  
    }
}
