using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.EF
{
    public class DatabaseContext : DbContext
    {
        public virtual DbSet<Hotel> Hotels { get; set; }
        public virtual DbSet<BeachHotel> BeachHotels { get; set; }
        public virtual DbSet<Lodging> Lodgings { get; set; }
        public virtual DbSet<Apartaments> Apartaments { get; set; }
        public virtual DbSet<GuestRoom> GuestRooms { get; set; }
        public virtual DbSet<House> Houses { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public DatabaseContext() { }
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = @"Server=localhost;Database=TravelAgency;Trusted_Connection=True;MultipleActiveResultSets=true";

            optionsBuilder.UseSqlServer(connectionString);

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
