using System.Data.Entity;

namespace Vodovoz.Models
{
    public class VodovozContext : DbContext
    {
        public VodovozContext() : base("DefaultConnection")
        {

        }

        public DbSet<Worker> Workers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}