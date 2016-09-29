namespace Booking.Models
{
    public class ReservationReview : IEntity<uint>
    {
        public uint Id { get; set; }
        public int Rating { get; set; }
        public string Review { get; set; }
        public uint ReservationId { get; set; }
        public Reservation Reservation { get; set; }
    }
}