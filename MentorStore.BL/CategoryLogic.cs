using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MentorStore.DAL;
using MentorStore.Domain;

namespace MentorStore.BL
{
    public class CategoryLogic : MainLogic<Category>, ICategoryLogic
    {
        StoreRepository<Category> _storeRepository = new StoreRepository<Category>();

        public IQueryable<Category> GetAllCategories()
        {
            return _storeRepository.GetAll();
        }
    }
}
