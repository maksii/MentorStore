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
        private TContext _entities = new TContext();
        public TContext Context
        {
            get
            {
                return _entities;
            }
            set
            {
                _entities = value;
            }
        }
        public virtual IQueryable<TEntity> GetAll()
        {
            var query = _entities.Set<TEntity>();
            return query;
        }
        public IQueryable<TEntity> GetBy(Expression<Func<TEntity, bool>> predicate)
        {
            var query = _entities.Set<TEntity>().Where(predicate);
            return query;
        }
        public virtual TEntity GetByID(int id)
        {
            var query = _entities.Set<TEntity>().Find(id);
            return query;
        }
        public virtual void Add(TEntity entity)
        {
            _entities.Set<TEntity>().Add(entity);
        }
        public virtual void Delete(TEntity entity)
        {
            _entities.Set<TEntity>().Remove(entity);
        }
        public virtual void Edit(TEntity entity)
        {
            _entities.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }
        public virtual void Save()
        {
            _entities.SaveChanges();
        }

        private bool _disposed = false;

        protected virtual void Dispose(bool disposing)
        {

            if (!this._disposed)
                if (disposing)
                    _entities.Dispose();

            this._disposed = true;
        }

        public void Dispose()
        {
            Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
