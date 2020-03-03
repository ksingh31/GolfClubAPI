using GolfClub.API.Models;
using Microsoft.EntityFrameworkCore;

namespace GolfClub.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<ReservationType> ReservationType { get; set; }
        public DbSet<TeeTime> TeeTime { get; set; }
    }
}