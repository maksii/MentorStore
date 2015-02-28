using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentorStore.DAL
{
    interface IRepository<TEntity>
        where TEntity : class
    {
    }
}
