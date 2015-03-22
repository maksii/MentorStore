using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MentorStore.Domain;

namespace MentorStore.Web.Models
{
    public class CategoryViewModel 
    {
        public Category Category { get; set; }
        public List<Product> Products { get; set; }
    }
}
