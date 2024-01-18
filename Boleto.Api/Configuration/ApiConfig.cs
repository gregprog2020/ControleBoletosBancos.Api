using ControleBoleto.Data;
using Microsoft.EntityFrameworkCore;

namespace ControleBoleto.Api.Configuration
{
    public static class ApiConfig
    {
        public static IServiceCollection AddApiConfig(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApiDbContext>(options =>
               options.UseNpgsql(configuration.GetConnectionString("DBConnection")));

            services.AddControllers();

            services.AddCors(options =>
            {
                options.AddPolicy("Total",
                    builder =>
                        builder
                            .AllowAnyOrigin()
                            .AllowAnyMethod()
                            .AllowAnyHeader());
            });

            return services;
        }

        public static void UseApiConfiguration(this IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment() || env.IsStaging())
            {
                app.UseDeveloperExceptionPage();
                                
            }


            app.UseHttpsRedirection();

            app.UseRouting();

            /*app.UseAuthConfiguration();*/

            app.UseCors("Total");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
