namespace Booking.Models
{
    public class RoomFeature : IEntity<uint>
    {
        public uint Id { get; set; }
        public string Feature { get; set; }
    }
}