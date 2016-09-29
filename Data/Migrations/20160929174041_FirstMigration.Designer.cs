using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Booking.Data;

namespace Booking_Angular.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20160929174041_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1");

            modelBuilder.Entity("Booking.Models.Availability", b =>
                {
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("EndDate");

                    b.Property<float>("Price");

                    b.Property<uint?>("RoomId");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.ToTable("Availability");
                });

            modelBuilder.Entity("Booking.Models.Company", b =>
                {
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("ReferenceName");

                    b.Property<string>("RegistrationNumber");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("Booking.Models.Property", b =>
                {
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<uint>("AddressId");

                    b.Property<uint>("CompanyId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("CompanyId");

                    b.ToTable("Properties");
                });

            modelBuilder.Entity("Booking.Models.Reservation", b =>
                {
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("EndDate");

                    b.Property<int>("ReservationStatus");

                    b.Property<uint>("RoomId");

                    b.Property<DateTime>("StartDate");

                    b.Property<uint>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.HasIndex("UserId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("Booking.Models.ReservationReview", b =>
                {
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Rating");

                    b.Property<uint>("ReservationId");

                    b.Property<string>("Review");

                    b.HasKey("Id");

                    b.HasIndex("ReservationId")
                        .IsUnique();

                    b.ToTable("ReservationReviews");
                });

            modelBuilder.Entity("Booking.Models.Room", b =>
                {
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<uint?>("PropertyId");

                    b.Property<string>("Reference");

                    b.Property<uint>("RoomBluePrintId");

                    b.HasKey("Id");

                    b.HasIndex("PropertyId");

                    b.HasIndex("RoomBluePrintId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("Booking.Models.RoomBluePrint", b =>
                {
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AdultGuests");

                    b.Property<int>("ChildGuests");

                    b.Property<string>("Description");

                    b.Property<uint>("PropertyId");

                    b.Property<int>("RoomType");

                    b.HasKey("Id");

                    b.HasIndex("PropertyId");

                    b.ToTable("RoomBluePrints");
                });

            modelBuilder.Entity("Booking.Models.RoomFeature", b =>
                {
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Feature");

                    b.Property<uint?>("RoomBluePrintId");

                    b.HasKey("Id");

                    b.HasIndex("RoomBluePrintId");

                    b.ToTable("RoomFeatures");
                });

            modelBuilder.Entity("Booking.Models.User", b =>
                {
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd();

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
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<uint>("CompanyId");

                    b.Property<int>("Profile");

                    b.Property<int>("Status");

                    b.Property<uint>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("UserId");

                    b.ToTable("UsersCompanies");
                });

            modelBuilder.Entity("Booking.Models.Util.Address", b =>
                {
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd();

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
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<uint?>("CompanyId");

                    b.Property<int>("CountryCode");

                    b.Property<string>("Number");

                    b.Property<uint?>("PropertyId");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("PropertyId");

                    b.ToTable("Phone");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole<uint>", b =>
                {
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd();

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<uint>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<uint>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<uint>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<uint>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<uint>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<uint>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<uint>", b =>
                {
                    b.Property<uint>("UserId");

                    b.Property<uint>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<uint>", b =>
                {
                    b.Property<uint>("UserId");

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
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Booking.Models.Company", "Company")
                        .WithMany("Properties")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Booking.Models.Reservation", b =>
                {
                    b.HasOne("Booking.Models.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Booking.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Booking.Models.ReservationReview", b =>
                {
                    b.HasOne("Booking.Models.Reservation", "Reservation")
                        .WithOne("Review")
                        .HasForeignKey("Booking.Models.ReservationReview", "ReservationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Booking.Models.Room", b =>
                {
                    b.HasOne("Booking.Models.Property")
                        .WithMany("Rooms")
                        .HasForeignKey("PropertyId");

                    b.HasOne("Booking.Models.RoomBluePrint", "RoomBluePrint")
                        .WithMany()
                        .HasForeignKey("RoomBluePrintId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Booking.Models.RoomBluePrint", b =>
                {
                    b.HasOne("Booking.Models.Property", "Property")
                        .WithMany("RoomBluePrints")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade);
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
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Booking.Models.User")
                        .WithMany("Companies")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<uint>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole<uint>")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<uint>", b =>
                {
                    b.HasOne("Booking.Models.User")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<uint>", b =>
                {
                    b.HasOne("Booking.Models.User")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<uint>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole<uint>")
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
