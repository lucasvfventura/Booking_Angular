namespace Booking.Models.Util
{
    public class Phone : IEntity
    {
        public string Id { get; set; }
        public string Number { get; set; }
        public int CountryCode { get; set; }
    }
}