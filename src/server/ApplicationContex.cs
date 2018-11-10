using Microsoft.EntityFrameworkCore;

using Hostel.Server.Model;

namespace Hostel.Server
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Inhabitant> Inhabitants { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Authorization> AuthorizationKeys { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=hosteldb;Trusted_Connection=True;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Each room has unique number;
            modelBuilder.Entity<Room>()
                .HasIndex(room => room.Number)
                .IsUnique();

            // Each customer has to have differenet full names to seperate the, apart;
            modelBuilder.Entity<Customer>()
                .HasIndex(customer => new {
                    customer.FirstName,
                    customer.SecondName,
                    customer.ThirdName})
                .IsUnique();

            // on checkout, room.customer set to null;
            modelBuilder.Entity<Inhabitant>()
                .HasOne(i => i.Room)
                .WithOne(r => r.Inhabitant)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Inhabitant>()
                .HasOne(i => i.Customer);
        }
    }
}