namespace PharmacyManagementAPI.Data
{
  
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel;
    using global::PharmacyManagementAPI.Entities;

    namespace PharmacyManagementAPI.Data
    {
        public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

            public DbSet<User> Users { get; set; }
            public DbSet<Product> Products { get; set; }
            public DbSet<License> Licenses { get; set; }
            public DbSet<Customer> Customers { get; set; }
            public DbSet<SalesOrder> SalesOrders { get; set; }
            public DbSet<Category> Categories { get; set; }
            public DbSet<SalesOrderItem> SalesOrderItems { get; set; }
            public DbSet<Payment> Payments { get; set; }
            public DbSet<Supplier> Suppliers { get; set; }
        }
    }

}
