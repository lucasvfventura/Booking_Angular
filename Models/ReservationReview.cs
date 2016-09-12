namespace Booking.Models
{
    public class ReservationReview : IEntity
    {
        public string Id { get; set; }
        public int Rating { get; set; }
        public string Review { get; set; }
        public string ReservationId { get; set; }
        public Reservation Reservation { get; set; }
    }
}