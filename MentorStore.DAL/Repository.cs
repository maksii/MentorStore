using System.Data.Entity;

namespace MentorStore.DAL
{
    class Repository<C, T> : IRepository<T>
        where T : class
        where C : DbContext, new()
    {
    }
}
