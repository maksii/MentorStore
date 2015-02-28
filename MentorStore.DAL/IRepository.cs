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
        int Add(TEntity enitiy);
        void Delete(TEntity enitiy);
        void Edit(TEntity enitiy);
        void Save();
    }
}
