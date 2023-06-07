using KilomeTravelAPI.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace KilomeTravelAPI.WebAPI.Context
{
    public class RentContext : DbContext
    {
        public DbSet<RentalItem> RentalItems { get; set; }
        public DbSet<RentalItemType> RentalItemTypes { get; set; }
        public DbSet<Clerk> Clerks { get; set; }
        public DbSet<RentOrder> RentOrders { get; set; }
        public DbSet<RentReturn> RentReturns { get; set; }

        public string DbPath { get; }

        public RentContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "renting.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var truckType = new RentalItemType { Id = 1, Name = "Truck", Enabled = true, HasFuel = true };
            var minivanType = new RentalItemType { Id = 2, Name = "Minivan", Enabled = true, HasFuel = true };
            var sedanType = new RentalItemType { Id = 3, Name = "Sedan", Enabled = true, HasFuel = true };

            modelBuilder.Entity<RentalItemType>().HasData(new RentalItemType[] {
                new RentalItemType { Id = 1, Name = "Truck", Enabled = true, HasFuel = true },
                new RentalItemType { Id = 2, Name = "Minivan", Enabled = true, HasFuel = true },
                new RentalItemType { Id = 3, Name = "Sedan", Enabled = true, HasFuel = true },
                // note: set these to enabled, if you want to display these types
                new RentalItemType { Id = 4, Name = "Bike", Enabled = false, HasFuel = true },
                new RentalItemType { Id = 5, Name = "Boat", Enabled = false, HasFuel = true },
                new RentalItemType { Id = 6, Name = "Holiday Cottage", Enabled = false, HasFuel = false },
                new RentalItemType { Id = 7, Name = "Hotel Room", Enabled = false, HasFuel = false },
            });

            modelBuilder.Entity<RentalItem>().HasData(new RentalItem[] {
                new RentalItem { Id = 1, Name = "Duster", RentalItemTypeId = 1, PricePerDay = 15 },
                new RentalItem { Id = 2, Name = "Ford Galaxy", RentalItemTypeId = 2, PricePerDay = 20 },
                new RentalItem { Id = 3, Name = "Dacia 1310", RentalItemTypeId = 3, PricePerDay = 10 },
            });
        }
    }
}
