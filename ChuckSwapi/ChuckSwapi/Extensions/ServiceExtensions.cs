using ChuckSwapi.Entities;
using ChuckSwapi.Services;
using Microsoft.EntityFrameworkCore;

namespace ChuckSwapi.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureContext(this IServiceCollection services, IConfiguration configuration)
            => services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("ChuckSwapiConStr")));
        public static void ConfigureCategoryService(this IServiceCollection services)
            => services.AddScoped<CategoryService>();
         public static void ConfigurePeopleService(this IServiceCollection services)
            => services.AddScoped<PeopleService>();
        public static void ConfigureCors(this IServiceCollection services)
       => services.AddCors(
           options =>
               options.AddPolicy("CorsPolicy", builder =>
               {
                   builder.WithOrigins("http://localhost:4200");
                   builder.AllowAnyMethod();
                   builder.AllowAnyHeader();
               })
           );
        public static void ConfigureIISIntegration(this IServiceCollection service)
        => service.Configure<IISOptions>(options => { });
        public static void ConfigurePeopleEndPoint(this IServiceCollection services, IConfiguration configuration)
            => services.AddHttpClient<PeopleApiService>(a => a.BaseAddress = new Uri(configuration["PeopleApiEndpoint"]));
        public static void ConfigureCategoryEndPoint(this IServiceCollection services, IConfiguration configuration)
            => services.AddHttpClient<PeopleApiService>(a => a.BaseAddress = new Uri(configuration["CategoryApiEndpoint"]));
    }
}
