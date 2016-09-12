using Booking.Data.Repositories.Abstract;
using Booking.Models;

namespace Booking.Data.Repositories
{
    public class RoomFeatureRepository : EntityRepository<RoomFeature>, IRoomFeatureRepository
    {
        public RoomFeatureRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}