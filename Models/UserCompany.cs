namespace Booking.Models
{
    public class UserCompany : IEntity<uint>
    {
        public uint Id { get; set; }
        public uint UserId { get; set; }
        public uint CompanyId { get; set; }
        public UserCompanyStatus Status { get; set; }
        public UserCompanyProfile Profile { get; set; }
    }

    public enum UserCompanyStatus {Activated, Deactivated}
    public enum UserCompanyProfile {Owner, Manager, Employee}
}