using Booking.Data.Repositories.Abstract;
using Booking.Models;

namespace Booking.Data.Repositories
{
    public class PropertyRepository : EntityRepository<Property>, IPropertyRepository
    {
        public PropertyRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}