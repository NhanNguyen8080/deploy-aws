using _2Sport_BE.Repository.Implements;
using demo.api.Interfaces;
using demo_api.Data;
using Microsoft.EntityFrameworkCore;

namespace demo.api.Extensions
{
    public static class ServiceCollection
    {
        public static void Register (this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddDbContext<TestDeployContext>(options => options
            .UseSqlServer(GetConnectionStrings()));
            
        }

        private static string GetConnectionStrings()
        {
            IConfigurationRoot config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();

            var strConn = config["ConnectionStrings:DefaultConnection"];
            return strConn; 
        }
    }
}
