using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    // Context : DB tabloları ile proje classlarını bağlamak
    public class ReCapProjectContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(@"Server=localhost;Database=rentacar;User=root;Password=12345;");
        }

        public DbSet<Car> Admins { get; set; }
        public DbSet<Car> Branchs { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Car> Cards { get; set; }
        public DbSet<Car> CarImages { get; set; }
        public DbSet<Car> CaseTypes { get; set; }
        public DbSet<Car> Classes { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Car> DrivingInformations { get; set; }
        public DbSet<Car> Employees { get; set; }
        public DbSet<Car> Fuels { get; set; }
        public DbSet<Car> Gears { get; set; }
        public DbSet<Car> IdentityInformations { get; set; }
        public DbSet<Car> Models { get; set; }
        public DbSet<Car> PhoneNumbers { get; set; }
        public DbSet<Car> RentalDetails { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Car> UserRoles { get; set; }
        
        
    }
}