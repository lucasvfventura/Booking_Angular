using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Booking.Data;

namespace Booking.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431");

            modelBuilder.Entity("Booking.Models.Availability", b =>
                {
                    b.Property<string>("Id");

                    b.Property<DateTime>("EndDate");

                    b.Property<float>("Price");

                    b.Property<string>("RoomId");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.ToTable("Availability");
                });

            modelBuilder.Entity("Booking.Models.Company", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("Name");

                    b.Property<string>("ReferenceName");

                    b.Property<string>("RegistrationNumber");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("Booking.Models.Property", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("AddressId");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Properties");
                });

            modelBuilder.Entity("Booking.Models.Reservation", b =>
                {
                    b.Property<string>("Id");

                    b.Property<DateTime>("EndDate");

                    b.Property<int>("ReservationStatus");

                    b.Property<string>("RoomId");

                    b.Property<DateTime>("StartDate");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.HasIndex("UserId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("Booking.Models.ReservationReview", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("Rating");

                    b.Property<string>("ReservationId");

                    b.Property<string>("Review");

                    b.HasKey("Id");

                    b.HasIndex("ReservationId")
                        .IsUnique();

                    b.ToTable("ReservationReviews");
                });

            modelBuilder.Entity("Booking.Models.Room", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("PropertyId");

                    b.Property<string>("Reference");

                    b.Property<string>("RoomBluePrintId");

                    b.HasKey("Id");

                    b.HasIndex("PropertyId");

                    b.HasIndex("RoomBluePrintId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("Booking.Models.RoomBluePrint", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AdultGuests");

                    b.Property<int>("ChildGuests");

                    b.Property<string>("Description");

                    b.Property<string>("PropertyId");

                    b.Property<int>("RoomType");

                    b.HasKey("Id");

                    b.HasIndex("PropertyId");

                    b.ToTable("RoomBluePrints");
                });

            modelBuilder.Entity("Booking.Models.RoomFeature", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("Feature");

                    b.Property<string>("RoomBluePrintId");

                    b.HasKey("Id");

                    b.HasIndex("RoomBluePrintId");

                    b.ToTable("RoomFeatures");
                });

            modelBuilder.Entity("Booking.Models.User", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<DateTime>("BirthDate");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("MiddleName");

                    b.Property<string>("NormalizedEmail")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedUserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<int>("UserType");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Booking.Models.UserCompany", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("CompanyId");

                    b.Property<int>("Profile");

                    b.Property<int>("Status");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("UserId");

                    b.ToTable("UsersCompanies");
                });

            modelBuilder.Entity("Booking.Models.Util.Address", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<double>("Latitude");

                    b.Property<double>("Longitude");

                    b.Property<string>("StreetAddress1");

                    b.Property<string>("StreetAddress2");

                    b.Property<string>("ZipCode");

                    b.HasKey("Id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("Booking.Models.Util.Phone", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("CompanyId");

                    b.Property<int>("CountryCode");

                    b.Property<string>("Number");

                    b.Property<string>("PropertyId");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("PropertyId");

                    b.ToTable("Phone");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Booking.Models.Availability", b =>
                {
                    b.HasOne("Booking.Models.Room")
                        .WithMany("Availabilities")
                        .HasForeignKey("RoomId");
                });

            modelBuilder.Entity("Booking.Models.Property", b =>
                {
                    b.HasOne("Booking.Models.Util.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");
                });

            modelBuilder.Entity("Booking.Models.Reservation", b =>
                {
                    b.HasOne("Booking.Models.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId");

                    b.HasOne("Booking.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Booking.Models.ReservationReview", b =>
                {
                    b.HasOne("Booking.Models.Reservation", "Reservation")
                        .WithOne("Review")
                        .HasForeignKey("Booking.Models.ReservationReview", "ReservationId");
                });

            modelBuilder.Entity("Booking.Models.Room", b =>
                {
                    b.HasOne("Booking.Models.Property")
                        .WithMany("Rooms")
                        .HasForeignKey("PropertyId");

                    b.HasOne("Booking.Models.RoomBluePrint", "RoomBluePrint")
                        .WithMany()
                        .HasForeignKey("RoomBluePrintId");
                });

            modelBuilder.Entity("Booking.Models.RoomBluePrint", b =>
                {
                    b.HasOne("Booking.Models.Property", "Property")
                        .WithMany("RoomBluePrints")
                        .HasForeignKey("PropertyId");
                });

            modelBuilder.Entity("Booking.Models.RoomFeature", b =>
                {
                    b.HasOne("Booking.Models.RoomBluePrint")
                        .WithMany("Features")
                        .HasForeignKey("RoomBluePrintId");
                });

            modelBuilder.Entity("Booking.Models.UserCompany", b =>
                {
                    b.HasOne("Booking.Models.Company")
                        .WithMany("Administrators")
                        .HasForeignKey("CompanyId");

                    b.HasOne("Booking.Models.User")
                        .WithMany("Companies")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Booking.Models.Util.Phone", b =>
                {
                    b.HasOne("Booking.Models.Company")
                        .WithMany("Phones")
                        .HasForeignKey("CompanyId");

                    b.HasOne("Booking.Models.Property")
                        .WithMany("Phones")
                        .HasForeignKey("PropertyId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Booking.Models.User")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Booking.Models.User")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Booking.Models.User")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
