using System.Data.Entity;
using PropertyAgency.Entities.Concrete;

namespace PropertyAgency.DataAccess.Concrete.EntityFramework
{
    public class PropertyAgencyContext : DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<House> Houses { get; set; }
        public DbSet<Kind> Kinds { get; set; }
    }
}
