﻿using Framework.Northwind.DataAccess.Concrete.EntityFramework.Mappings;
using Framework.Northwind.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace Framework.Northwind.DataAccess.Concrete.EntityFramework
{
  public   class NorthwindContext:DbContext
    {
        public NorthwindContext()
        {
            Database.SetInitializer<NorthwindContext>(null);
        }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductMap());
        }
    }
}
