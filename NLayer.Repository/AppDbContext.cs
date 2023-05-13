﻿using Microsoft.EntityFrameworkCore;
using NLayer.CoreLayer.Models;
using NLayer.Repository.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //scan assembly and find configration classes whice inherits IEntityTypeConfiguration<entity>
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            //other way
            //modelBuilder.ApplyConfiguration(new ProductConfiguration());

            modelBuilder
                .Entity<ProductFeature>()
                .HasData(
                new ProductFeature
                {
                    Id = 1,
                    Color = "Kırmızı",
                    Height = 100,
                    Width = 200,
                    ProductId = 1,
                },
                new ProductFeature
                {
                    Id = 2,
                    Color = "Mavi",
                    Height = 300,
                    Width = 500,
                    ProductId = 2,
                });
        }
    }
}
