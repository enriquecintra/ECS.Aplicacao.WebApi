using ECS.Aplicacao.WebApi.Models;
using ECS.Framework.Data;
using Microsoft.Extensions.Logging;

namespace ECS.Aplicacao.WebApi.Services
{
    public class ClienteService : Service<Cliente>
    {
        protected IRepository<Cliente> _repository;
        public ClienteService(IRepository<Cliente> repository, ILogger<ClienteService> logger) : base(repository, logger)
        {
            _repository = repository;
        }
    }
}
