using System;
using System.Linq;
using System.Linq.Expressions;
namespace MentorStore.DAL
{
    public interface IRepository<TEntity>
        where TEntity : class
    {
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> GetBy(Expression<Func<TEntity, bool>> predicate);
        TEntity GetByID(int id);
        int Add(TEntity entity);
        void Delete(TEntity entity);
        void Edit(TEntity entity);
        void Save();
    }
}
