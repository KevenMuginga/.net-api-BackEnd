using Microsoft.EntityFrameworkCore;
using Pessoas_Data;

namespace Pessoas_Api.Configuration
{
    public static class DataBaseConfiguration
    {
        public static void AddDataBaseConfiguration(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContext<PessoaContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("pessoaConnection")));
        }
    }
}
