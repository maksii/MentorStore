using System.Data.Entity;
using MentorStore.Domain;

namespace MentorStore.DAL.DB
{
    public partial class StoreContext : Context
    {
        public StoreContext() : base("name=MentorStore")
        {

        }

        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
    }
}
