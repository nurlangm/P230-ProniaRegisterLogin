﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using P230_Pronia.Entities;

namespace P230_Pronia.DAL
{
    public class ProniaDbContext:IdentityDbContext<User>
    {
        public ProniaDbContext(DbContextOptions<ProniaDbContext> options):base(options)
        {
            
        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Plant> Plants { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<PlantDeliveryInformation> PlantDeliveryInformation { get; set; }
        public DbSet<PlantImage> PlantImages { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<PlantCategory> PlantCategories { get; set; }   

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Setting>()
                .HasIndex(s => s.Key)
                .IsUnique();
            base.OnModelCreating(modelBuilder);
        }


    }
}
