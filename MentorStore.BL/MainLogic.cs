using System;
using System.Linq;
using System.Linq.Expressions;
using MentorStore.DAL;

namespace MentorStore.BL
{
    public class MainLogic<TEntity> : IMainLogic<TEntity> where TEntity: class 
    {
        StoreRepository<TEntity> _storeRepository = new StoreRepository<TEntity>(); 

        public void AddEntity(TEntity entity)
        {
            _storeRepository.Add(entity);
            _storeRepository.Save();
        }

        public void DeleteEntity(TEntity entity)
        {
           _storeRepository.Delete(entity);
           _storeRepository.Save();
        }

        public void EditEntity(TEntity entity)
        {
          _storeRepository.Edit(entity);
          _storeRepository.Save();
        }

        public IQueryable<TEntity> SearchFor(Expression<Func<TEntity, bool>> predicate)
        {
           IQueryable<TEntity> resultEntities = _storeRepository.GetBy(predicate);

            return resultEntities;
        }

        public IQueryable<TEntity> GetAll()
        {
            IQueryable<TEntity> resultEntities = _storeRepository.GetAll();

            return resultEntities;
        }

        public TEntity GetEntityById(int id)
        {
            TEntity resultEntity = _storeRepository.GetByID(id);

            return resultEntity;
        }
    }
}
