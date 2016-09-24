using Booking.Data.Repositories.Abstract;
using Booking.Models;

namespace Booking.Data.Repositories
{
    public class UserCompanyRepository : EntityRepository<UserCompany>, IUserCompanyRepository
    {
        public UserCompanyRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}