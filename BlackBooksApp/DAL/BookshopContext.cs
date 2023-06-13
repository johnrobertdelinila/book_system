using BlackBooksApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace BlackBooksApp.DAL
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class BookshopContext : DbContext
    {
        public BookshopContext() : base("conn")
        {
        }
        public DbSet<Models.Type> Types { get; set; }
        public DbSet<PublishingHouse> PublishingHouses { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Purchased> PurchasedBooks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}