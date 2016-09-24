using Booking.Data.Repositories.Abstract;
using Booking.Models;

namespace Booking.Data.Repositories
{
    public class UserRepository : EntityRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context)
        {
        }

        public User GetSingleByUsername(string username)
        {
            return GetSingle(user => user.UserName == username);
        }
    }
}