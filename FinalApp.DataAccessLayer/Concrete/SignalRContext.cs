using FinalApp.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinalApp.DataAccessLayer.Concrete
{
    public class SignalRContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-LUU9GH6;initial Catalog=FinalAppDb;integrated Security=true;TrustServerCertificate=true;");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Product> Products { get; set; }
        


    }
}

