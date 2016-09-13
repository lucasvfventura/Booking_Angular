using System.Threading.Tasks;

namespace Booking.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
