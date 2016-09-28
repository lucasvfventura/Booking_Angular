using AutoMapper;
using Booking.Models.ViewModels;

namespace Booking.Models
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(config =>
            {
                config.AddProfile<ModelToViewModelMappingProfile>();
            });
        }
    }
}
