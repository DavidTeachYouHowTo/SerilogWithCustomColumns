using Microsoft.Extensions.DependencyInjection;
using Serilog.Services.Service.Abstract;
using Serilog.Services.Service.Concrete;

namespace Serilog.Services.Configuration.DependencyInjection
{
    public static partial class ServicesConfiguration
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<ISerilogServices, SerilogServices>();
            services.AddScoped<IUserServices, UserServices>();
            services.AddScoped<ISerilogWriteEventServices, SerilogWriteEventServices>();
        }
    }
}
