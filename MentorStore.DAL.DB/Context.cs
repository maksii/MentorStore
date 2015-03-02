using System.Data.Entity;

namespace MentorStore.DAL.DB
{
    public abstract class Context : DbContext, IContext
    {
        public Context() : base() { }
        public Context(string connectionString) : base(connectionString) { }

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }
    }
}
