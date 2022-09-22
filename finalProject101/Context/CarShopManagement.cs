using finalProject101.Models;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace finalProject101.Context
{
    public class CarShopManagement:DbContext
    {
        public CarShopManagement():base("CarShopDbContext")
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Product> Products { get; set; }


    }
}