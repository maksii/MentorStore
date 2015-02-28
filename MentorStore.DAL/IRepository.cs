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
        TEntity GetByID(object id);
        object Add(TEntity obj);
        void Delete(TEntity obj);
        void Edit(TEntity obj);
        void Save();
    }
}
