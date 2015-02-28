using System.Collections.Generic;

namespace MentorStore.Domain
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public List<Product> Products { get; set; } 
    }
}
