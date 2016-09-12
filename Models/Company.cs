using System;
using System.Collections.Generic;
using Booking.Models.Util;

namespace Booking.Models
{
    public class Company : IEntity
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string RegistrationNumber { get; set; }
        public string ReferenceName { get; set; }
        public List<Phone> Phones { get; set; }
        public List<UserCompany> Administrators { get; set; }
    }
}