using Microsoft.EntityFrameworkCore;
using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        //product feature aslında products üzerinden doldurulmalı
        // öğrenmek amaçlı açık tutuyoruz
        public DbSet<ProductFeature> ProductFeatures { get; set; }



        // fluent api
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // assembly tüm classlara denk oluyor
            // şimdi configurations altındaki yada 
            // herhangi bir katmandaki IEntityTypeConfiguration
            // interface'ini modelBuilder üzerinden ulaşacağız
            // calıştığım katmandaki assembly de ara
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
    }
}
