using System;

namespace Booking.Models
{
    public class UserCompany : IEntity
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string CompanyId { get; set; }
        public UserCompanyStatus Status { get; set; }
        public UserCompanyProfile Profile { get; set; }
    }

    public enum UserCompanyStatus {Activated, Deactivated}
    public enum UserCompanyProfile {Owner, Manager, Employee}
}