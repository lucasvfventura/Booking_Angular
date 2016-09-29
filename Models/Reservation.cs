using System;

namespace Booking.Models
{
    public class Reservation : IEntity<uint>
    {
        public uint Id { get; set; }
        public uint UserId { get; set; }
        public User User { get; set; }
        public uint RoomId { get; set; }
        public Room Room { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ReservationStatus ReservationStatus { get; set; }
        public ReservationReview Review { get; set; }
    }

    public enum ReservationStatus {WaitingPayment, Confirmed, InProgress, Cancelled, Finished}
}