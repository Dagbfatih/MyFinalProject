using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    // context : Db tabloları ile proje class'larını bağlamak
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database=Northwind;Trusted_Connection=true"); // @: '\' işaretini normalde '\\' şeklinde yazmak gerekirken, '@' işaretini çift tırnakların başına koyunca'\' işareti  bir sıkıntı çıkarmaz.
        }

        public DbSet<Product> Products { get; set; } // Benim product'um veirtabanındaki products tablosuna denk geliyor
        public DbSet<Category> Categories { get; set; } // DbSet<> yapısı veritabanı ile bizim class'larımız arasında ilişki kurmamızı sağlar
        public DbSet<Customer> Customers { get; set; }
    }
}
