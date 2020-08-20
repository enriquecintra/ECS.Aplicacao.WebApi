using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ECS.Aplicacao.WebApi.Models
{
    public class LocalDbContext : DbContext
    {
        private IConfiguration _configuration;

        public LocalDbContext(IConfiguration configuration,
                                    DbContextOptions options)
            : base(options)
        {
            _configuration = configuration;
        }
        public virtual DbSet<Cliente> Cliente { get; set; }
    }
}
