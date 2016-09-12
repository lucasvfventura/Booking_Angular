using System.Collections.Generic;
using Booking.Models.Util;

namespace Booking.Models
{
    public class Property : IEntity
    {
        public string Id { get; set; }
        public List<Phone> Phones { get; set; }
        public string AddressId { get; set; }
        public Address Address { get; set; }
        public List<Room> Rooms { get; set; }
        public List<RoomBluePrint> RoomBluePrints { get; set; }
    }
}