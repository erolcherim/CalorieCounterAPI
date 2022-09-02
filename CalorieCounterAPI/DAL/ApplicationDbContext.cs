﻿using CalorieCounterAPI.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace CalorieCounterAPI.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<UserFood> UserFoods { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserFood>()
                .HasOne(userfood => userfood.User)
                .WithMany(user => user.UserFoods);

            modelBuilder.Entity<UserFood>()
                .HasOne(userfood => userfood.Food)
                .WithMany(food => food.UserFoods);
        }
    }
}
