using MentorStore.DAL.DB;

namespace MentorStore.DAL
{
    public class StoreRepository<TEntity> : Repository<StoreContext, TEntity>, IStoreRepository<TEntity> where TEntity : class 
    {

    }
}
