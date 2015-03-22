using System.ComponentModel.DataAnnotations.Schema;
namespace MentorStore.Domain
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        [ForeignKey("Category")]
        public int Category_Id { get; set; }
        public virtual Category Category { get; set; }
    }
}
