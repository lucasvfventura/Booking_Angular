using System.Collections.Generic;

namespace Booking.Models
{
    public class Room : IEntity
    {
        public string Id { get; set; }
        public string Reference { get; set; }
        public RoomBluePrint RoomBluePrint { get; set; }
        public List<Availability> Availabilities { get; set; }
    }
}