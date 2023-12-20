using Microsoft.EntityFrameworkCore;
using RelationalApp.Models;

namespace RelationalApp.Data
{
    public class RelationalDbContext:DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Basket> Baskets { get; set; }

        public RelationalDbContext()
        {

        }

        public RelationalDbContext(DbContextOptions options) : base(options)
        {
        }

       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //  optionsBuilder.UseSqlite("Data Source=mydatabase.db");
            optionsBuilder.UseSqlServer("Data Source=(local);Initial Catalog=relationalDb; Integrated Security = True;TrustServerCertificate=True;");
        }
    }
}
