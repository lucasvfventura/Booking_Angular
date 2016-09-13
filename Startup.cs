using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Booking.Data;
using Booking.Models;
using Booking.Services;
using Booking.Data.Repositories;
using Booking.Data.Repositories.Abstract;
using Newtonsoft.Json.Serialization;

namespace Booking
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);

            if (env.IsDevelopment())
            {
                // For more details on using the user secret store see https://go.microsoft.com/fwlink/?LinkID=532709
                builder.AddUserSecrets();
            }

            builder.AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlite(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserCompanyRepository, UserCompanyRepository>();
            services.AddScoped<ICompanyRepository, CompanyRepository>();
            services.AddScoped<IPropertyRepository, PropertyRepository>();
            services.AddScoped<IRoomBluePrintRepository, RoomBluePrintRepository>();
            services.AddScoped<IRoomFeatureRepository, RoomFeatureRepository>();
            services.AddScoped<IRoomRepository, RoomRepository>();
            services.AddScoped<IAvailabilityRepository, AvailabilityRepository>();
            services.AddScoped<IReservationRepository, ReservationRepository>();
            services.AddScoped<IReservationReviewRepository, ReservationReviewRepository>();

            services.AddMvc()
                .AddJsonOptions(opt =>
                {
                    var resolver = opt.SerializerSettings.ContractResolver;
                    if (resolver != null)
                    {
                        var res = resolver as DefaultContractResolver;
                        res.NamingStrategy = null;
                    }
                });

            // Add application services.
            services.AddTransient<IEmailSender, AuthMessageSender>();
            services.AddTransient<ISmsSender, AuthMessageSender>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseDefaultFiles();
            app.UseStaticFiles();

            app.UseIdentity();

            // Add external authentication middleware below. To configure them please see https://go.microsoft.com/fwlink/?LinkID=532715

            app.UseMvc(routes => {
                routes.MapRoute(
                    name: "api",
                    template: "api/{controller}/{id?}"
                );
            });

            // app.UseMvc(routes => {
            //     routes.MapRoute(
            //         name: "Default",
            //         template: "/{controller=Home}/{action=Index}/{id?}"
            //     );
            // });
        }
    }
}
