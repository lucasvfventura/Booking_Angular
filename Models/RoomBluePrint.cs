namespace Booking.Models
{
    public class RoomBluePrint : IEntity
    {
        public string Id { get; set; }
        public RoomType RoomType { get; set; }
        public string Description { get; set; }
        
        //TODO: add pictures
        //TODO: add features
        
        public string PropertyId { get; set; }
        public Property Property { get; set; }
    }

    public enum RoomType {Private, Shared, Suite}
}