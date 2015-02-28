using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentorStore.Domain
{
    public class Order : BaseEntity
    {
        public string TrackingNumber { get; set; }
        public string Address { get; set; }
        public string CustomerName { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
