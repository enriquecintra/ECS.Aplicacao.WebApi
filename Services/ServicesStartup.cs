using Microsoft.Extensions.DependencyInjection;

namespace ECS.Aplicacao.WebApi.Services
{
    public class ServicesStartup
    {
        public static void StartupServices(IServiceCollection services)
        {
            services.AddScoped<ClienteService>();
        }
    }
}
