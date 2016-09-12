using System;

namespace Booking.Models
{
    public class Reservation : IEntity
    {
        public string Id { get; set; }
        public User User { get; set; }
        public Room Room { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ReservationStatus ReservationStatus { get; set; }
    }

    public enum ReservationStatus {WaitingPayment, Confirmed, InProgress, Cancelled, Finished}
}