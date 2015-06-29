using CharterERP.Backend.Domain;
using CharterERP.Backend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharterERP.Backend.Repository
{
    public class EFDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Dealer> Dealers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet <Account> Accounts { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Customer> Customers { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Products");
            modelBuilder.Entity<Dealer>().ToTable("Dealers");
            modelBuilder.Entity<Employee>().ToTable("Employees");
            modelBuilder.Entity<Store>().ToTable("Stores");
            modelBuilder.Entity<Account>().ToTable("Accounts");
            modelBuilder.Entity<Vehicle>().ToTable("Vehicles");
            modelBuilder.Entity<Customer>().ToTable("Customers");

        }

    }



}
