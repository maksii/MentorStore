using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MentorStore.Domain;

namespace MentorStore.BL
{
    public interface IProductLogic : IMainLogic<Domain.Product>
    {
        IQueryable<Product> GetAllCategoryProducts(int? id);
    }
}
