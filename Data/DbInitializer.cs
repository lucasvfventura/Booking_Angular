using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Booking.Models;
using Booking.Models.Util;

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
            context.Companies.RemoveRange(context.Companies);
            context.Properties.RemoveRange(context.Properties);
            context.SaveChanges();

            for (int i = 0; i < 10; i++)
            {
                var company = new Company()
                {
                    Name = $"Company {i}"
                };

                var property = new Property()
                {
                    Name = $"Property {i} of Company {i}",
                    Address = new Address() { City = "Burnaby", Country = "Canada"},
                    Company = company
                };

                company.Properties.Add(property);

            context.Companies.Add(company);
            }
            context.SaveChanges();
        }
    }
}
