using AutoMapper;
using Pessoas_Core.Models;
using Pessoas_CoreShared.Pessoa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoas_Manager.mapping
{
    public class PessoasMappingProfile : Profile
    {
        public PessoasMappingProfile()
        {
            CreateMap<Pessoa, NovaPessoa>().ReverseMap();
            CreateMap<Pessoa, AlterarPessoa>().ReverseMap();
        }
    }
}
