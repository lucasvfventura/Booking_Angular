namespace Booking.Models.Util
{
    public class Phone : IEntity<uint>
    {
        public uint Id { get; set; }
        public string Number { get; set; }
        public int CountryCode { get; set; }
    }
}