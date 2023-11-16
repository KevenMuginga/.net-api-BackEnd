using Pessoas_Data.Repository;
using Pessoas_Manager.implementation;
using Pessoas_Manager.interfaces;

namespace Pessoas_Api.Configuration
{
    public static class DependencyInjectionConfiguration
    {
        public static void AddDepedencyInjectionConfig(this IServiceCollection services)
        {
            services.AddScoped<IPessoaRepository, PessoaRepository>();
            services.AddScoped<IPessoaManager, PessoaManager>();
        }
    }
}
