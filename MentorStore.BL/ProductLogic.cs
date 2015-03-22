using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MentorStore.DAL;
using MentorStore.Domain;

namespace MentorStore.BL
{
    public class ProductLogic : MainLogic<Product>, IProductLogic 
    {
        StoreRepository<Product> _storeRepository = new StoreRepository<Product>();

        public IQueryable<Product> GetAllCategoryProducts(int id)
        {
            return _storeRepository.GetBy(cat => cat.Category_Id == id);
        }
    }
}
