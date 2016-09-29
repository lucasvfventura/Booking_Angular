using System.Collections.Generic;
using Booking.Models.Util;

namespace Booking.Models
{
    public class Property : IEntity<uint>
    {
        public Property ()
        {
            Phones =  new List<Phone>();
            Rooms = new List<Room>();
            RoomBluePrints = new List<RoomBluePrint>();
        }
        public uint Id { get; set; }
        public string Name { get; set; }
        public uint CompanyId { get; set; }
        public Company Company { get; set; }
        public List<Phone> Phones { get; set; }
        public uint AddressId { get; set; }
        public Address Address { get; set; }
        public List<Room> Rooms { get; set; }
        public List<RoomBluePrint> RoomBluePrints { get; set; }
    }
}