using System.Data.Entity;

namespace MentorStore.DAL
{
    public class Repository<TContext, TEntity> : IRepository<TEntity>
        where TEntity : class
        where TContext : DbContext, new()
    {
    }
}
