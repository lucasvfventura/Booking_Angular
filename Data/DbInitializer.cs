using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Booking.Models;

namespace Booking.Data
{
    public class DbInitializer
    {
        private static ApplicationDbContext context;

        public static void Init(IServiceProvider provider)
        {
            context = provider.GetService<ApplicationDbContext>();

            InitCompanies();
        }

        private static void InitCompanies()
        {
            if (!context.Companies.Any())
            {
                for (int i = 0; i < 10; i++)
                {
                    context.Companies.Add(new Company()
                    {
                        //TODO: remove id setting
                        Id = $"{i}",
                        Name = $"Company {i}"
                    });
                }
                context.SaveChanges();
            }
        }
    }
}
