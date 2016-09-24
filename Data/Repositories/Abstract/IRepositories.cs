using Booking.Models;

namespace Booking.Data.Repositories.Abstract
{
    public interface IUserRepository : IEntityRepository<User> 
    {
        User GetSingleByUsername(string username);
    }

    public interface IUserCompanyRepository : IEntityRepository<UserCompany> { }
    public interface ICompanyRepository : IEntityRepository<Company> { }
    public interface IPropertyRepository : IEntityRepository<Property> { }
    public interface IRoomRepository : IEntityRepository<Room> { }
    public interface IRoomBluePrintRepository : IEntityRepository<RoomBluePrint> { }
    public interface IRoomFeatureRepository : IEntityRepository<RoomFeature> { }
    public interface IAvailabilityRepository : IEntityRepository<Availability> { }
    public interface IReservationRepository : IEntityRepository<Reservation> { }
    public interface IReservationReviewRepository : IEntityRepository<ReservationReview> { }
}
