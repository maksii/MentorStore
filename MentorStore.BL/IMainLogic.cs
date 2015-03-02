using System;
using System.Linq;
using System.Linq.Expressions;

namespace MentorStore.BL
{
    public interface IMainLogic<TEntity> where TEntity: class 
    {
        void AddEntity(TEntity entity);
        void DeleteEntity(TEntity entity);
        void EditEntity(TEntity entity);
        IQueryable<TEntity> SearchFor(Expression<Func<TEntity, bool>> predicate);
        IQueryable<TEntity> GetAll();
        TEntity GetEntityById(int id);
    }
}
