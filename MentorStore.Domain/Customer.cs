using System.Collections.Generic;

namespace MentorStore.Domain
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public List<Order> Orders { get; set; }
    }
}
