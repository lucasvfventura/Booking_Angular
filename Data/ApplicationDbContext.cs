using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Booking.Models;

namespace Booking.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<UserCompany> UsersCompanies { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomBluePrint> RoomBluePrints { get; set; }
        public DbSet<RoomFeature> RoomFeatures { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<ReservationReview> ReservationReviews { get; set; }
        

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
