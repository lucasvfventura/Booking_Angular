using Booking.Data.Repositories.Abstract;
using Booking.Models;

namespace Booking.Data.Repositories
{
    public class AvailabilityRepository : EntityRepository<Availability>, IAvailabilityRepository
    {
        public AvailabilityRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}