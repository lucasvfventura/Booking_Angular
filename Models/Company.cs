using System.Collections.Generic;
using Booking.Models.Util;
using System.ComponentModel.DataAnnotations;

namespace Booking.Models
{
    public class Company : IEntity<uint>
    {
        public Company ()
        {
            Phones = new List<Phone>();
            Administrators = new List<UserCompany>();
            Properties = new List<Property>();
        }

        public uint Id { get; set; }
        public string Name { get; set; }
        public string RegistrationNumber { get; set; }
        public string ReferenceName { get; set; }
        public List<Phone> Phones { get; set; }
        public List<UserCompany> Administrators { get; set; }
        public List<Property> Properties { get; set; }
    }
}