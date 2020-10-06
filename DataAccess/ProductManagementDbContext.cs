using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using WebAPI.Models;

namespace WebAPI.DataAccess
{
    public class ProductManagementDbContext : DbContext
    {
        public ProductManagementDbContext() : base("name=MyDatabaseConnection")
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
    }

}