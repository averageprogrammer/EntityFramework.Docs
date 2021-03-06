﻿using Microsoft.Data.Entity;

namespace EFModeling.Configuring.FluentAPI.Samples.KeySingle
{
    class MyContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>()
                .Key(c => c.LicensePlate);
        }
    }

    class Car
    {
        public string LicensePlate { get; set; }

        public string Make { get; set; }
        public string Model { get; set; }
    }
}
