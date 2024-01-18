using ControleBoleto.Data;
using ControleBoleto.Data.Repository;
using ControleBoleto.Domain.Interfaces;
using ControleBoleto.Domain.Services;

namespace ControleBoleto.Api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<ApiDbContext>();
            //Repository
            services.AddScoped<IBoletoRepository, BoletoRepository>();
            services.AddScoped<IBancoRepository, BancoRepository>();
            //Services
            services.AddScoped<IBoletoServices, BoletoServices>();
            services.AddScoped<IBancoService, BancoServices>();

            return services;
        }
    }
}