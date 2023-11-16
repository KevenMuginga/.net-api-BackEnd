using Pessoas_Manager.mapping;

namespace Pessoas_Api.Configuration
{
    public static class AutoMapperConsiguration
    {
        public static void AddMapperConnfiguration(this IServiceCollection Service)
        {
            Service.AddAutoMapper(typeof(PessoasMappingProfile));
        }
    }
}
