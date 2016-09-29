using Booking.Models;

namespace Booking.Data.Repositories.Abstract
{
    public interface IUserRepository : IEntityRepository<User, uint> 
    {
        User GetSingleByUsername(string username);
    }

    public interface IUserCompanyRepository : IEntityRepository<UserCompany, uint> { }
    public interface ICompanyRepository : IEntityRepository<Company, uint> { }
    public interface IPropertyRepository : IEntityRepository<Property, uint> { }
    public interface IRoomRepository : IEntityRepository<Room, uint> { }
    public interface IRoomBluePrintRepository : IEntityRepository<RoomBluePrint, uint> { }
    public interface IRoomFeatureRepository : IEntityRepository<RoomFeature, uint> { }
    public interface IAvailabilityRepository : IEntityRepository<Availability, uint> { }
    public interface IReservationRepository : IEntityRepository<Reservation, uint> { }
    public interface IReservationReviewRepository : IEntityRepository<ReservationReview, uint> { }
}
