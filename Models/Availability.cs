using System;

namespace Booking.Models
{
    public class Availability : IEntity<uint>
    {
        public uint Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public float Price { get; set; }
    }
}