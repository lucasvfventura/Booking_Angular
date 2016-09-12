using Booking.Data.Repositories.Abstract;
using Booking.Models;

namespace Booking.Data.Repositories
{
    public class RoomBluePrintRepository : EntityRepository<RoomBluePrint>, IRoomBluePrintRepository
    {
        public RoomBluePrintRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}