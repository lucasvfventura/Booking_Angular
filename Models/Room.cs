using System.Collections.Generic;

namespace Booking.Models
{
    public class Room : IEntity<uint>
    {
        public Room ()
        {
            Availabilities = new List<Availability>();
        }
        public uint Id { get; set; }
        public string Reference { get; set; }
        public uint RoomBluePrintId { get; set; }
        public RoomBluePrint RoomBluePrint { get; set; }
        public List<Availability> Availabilities { get; set; }
    }
}