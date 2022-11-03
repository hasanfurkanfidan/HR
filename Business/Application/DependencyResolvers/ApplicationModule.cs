using Microsoft.Extensions.DependencyInjection;

namespace Application.DependencyResolvers
{
    public class ApplicationModule
    {
        public static void Load(IServiceCollection services)
        {
            services.AddAutoMapper(configAction =>
            {
               
            }, typeof(ApplicationModule).Assembly);
        }
    }
}
