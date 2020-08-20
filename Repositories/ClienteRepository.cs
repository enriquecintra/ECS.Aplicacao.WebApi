using Microsoft.Extensions.Logging;
using ECS.Aplicacao.WebApi.Models;
using ECS.Framework.Data;

namespace ECS.Aplicacao.WebApi.Repositories
{
    public class ClienteRepository : Repository<Cliente>, IRepository<Cliente>
    {
        private LocalDbContext _dbContext;

        public ClienteRepository(LocalDbContext dbContext,
                                 ILogger<ClienteRepository> logger,
                                 DapperRepositoryUtils dapperRepositoryUtils,
                                 CacheWrapper cache) : base(dbContext, logger, dapperRepositoryUtils, cache)
        {
            _dbContext = dbContext;
        }
    }
}
