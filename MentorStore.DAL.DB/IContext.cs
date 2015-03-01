using System;
using System.Data.Entity;

namespace MentorStore.DAL.DB
{
    interface IContext : IDisposable
    {
        IDbSet<TEntity> Set<TEntity>() where TEntity : class;
        int SaveChanges();
    }
}
