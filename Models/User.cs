using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Booking.Models
{
    public class User : IdentityUser, IEntity
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public UserType UserType { get; set; }
        public List<UserCompany> Companies { get; set; }
    }

    public enum UserType {Customer, Administrator};
}
