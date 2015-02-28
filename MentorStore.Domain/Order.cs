using System;

namespace MentorStore.Domain
{
    public class Order : BaseEntity
    {
        public string TrackingNumber { get; set; }
        public string Address { get; set; }
        public Customer Customer { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public Product Products { get; set; }
    }
}
