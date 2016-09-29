using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Booking.Models
{
    public class User : IdentityUser<uint>, IEntity<uint>
    {
        public User ()
        {
            Companies =  new List<UserCompany>();
            UserType = UserType.Customer;
        }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public UserType UserType { get; set; }
        public List<UserCompany> Companies { get; set; }
    }

    public enum UserType {Customer, Administrator}
}
