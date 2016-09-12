using System.Collections.Generic;
using Booking.Models.Util;

namespace Booking.Models
{
    public class Property : IEntity
    {
        public Property ()
        {
            Phones =  new List<Phone>();
            Rooms = new List<Room>();
            RoomBluePrints = new List<RoomBluePrint>();
        }
        public string Id { get; set; }
        public List<Phone> Phones { get; set; }
        public string AddressId { get; set; }
        public Address Address { get; set; }
        public List<Room> Rooms { get; set; }
        public List<RoomBluePrint> RoomBluePrints { get; set; }
    }
}