using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public UserType UserTypes { get; set; }
        public UserCompany UsersCompanies { get; set; }
        public UserCompanyStatus UserCompanyStatus { get; set; }
        public UserCompanyProfile UserCompanyProfiel { get; set; }
        public Company Companies { get; set; }
        public Property Properties { get; set; }
        public Room Rooms { get; set; }
        public RoomBluePrint RoomBluePrints { get; set; }
        public RoomType RoomTypes { get; set; }
        public RoomFeature RoomFeatures { get; set; }
        public Reservation Reservations { get; set; }
        public ReservationStatus ReservationStatus { get; set; }
        public ReservationReview ReservationReviews { get; set; }
        

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
