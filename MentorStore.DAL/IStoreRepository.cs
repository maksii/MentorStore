namespace MentorStore.DAL
{
    public interface IStoreRepository<TEntity> : IRepository<TEntity> where TEntity : class 
    {

    }
}
