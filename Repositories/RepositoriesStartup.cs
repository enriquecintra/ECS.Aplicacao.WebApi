using ECS.Aplicacao.WebApi.Models;
using ECS.Framework.Data;
using Microsoft.Extensions.DependencyInjection;

namespace ECS.Aplicacao.WebApi.Repositories
{
    public class RepositoriesStartup
    {
        public static void StartupRepositories(IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<Cliente>), typeof(ClienteRepository));
        }
    }
}
