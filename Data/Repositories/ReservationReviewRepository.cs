using Booking.Data.Repositories.Abstract;
using Booking.Models;

namespace Booking.Data.Repositories
{
    public class ReservationReviewRepository : EntityRepository<ReservationReview>, IReservationReviewRepository
    {
        public ReservationReviewRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}