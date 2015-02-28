using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace MentorStore.DAL
{
    public abstract class Repository<TContext, TEntity> : IRepository<TEntity>
        where TEntity : class
        where TContext : DbContext, new()
    {
        private TContext context;
        public TContext Context
        {
            get
            {
                return context;
            }
            set
            {
                context = value;
            }
        }
        public virtual IQueryable<TEntity> GetAll()
        {
            return context.Set<TEntity>();
        }
        public IQueryable<TEntity> GetBy(Expression<Func<TEntity, bool>> predicate)
        {
            return context.Set<TEntity>().Where(predicate);
        }
        public virtual TEntity GetByID(int id)
        {
            return context.Set<TEntity>().Find(id);
        }
        public abstract int Add(TEntity entity); //no idea
        public virtual void Delete(TEntity entity)
        {
            context.Set<TEntity>().Remove(entity);
        }
        public virtual void Edit(TEntity entity)
        {
            context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }
        public virtual void Save()
        {
            context.SaveChanges();
        }
    }
}
