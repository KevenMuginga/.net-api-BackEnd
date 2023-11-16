using AutoMapper;
using Pessoas_Core.Models;
using Pessoas_CoreShared.Pessoa;
using Pessoas_Manager.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoas_Manager.implementation
{
    public class PessoaManager: IPessoaManager
    {
        private readonly IPessoaRepository _repository;
        private readonly IMapper mapper;

        public PessoaManager(IPessoaRepository _repository, IMapper _mapper)
        {
            this._repository = _repository;
            this.mapper = _mapper;
        }

        public async Task<IEnumerable<Pessoa>> GetAsync()
        {
            return await _repository.GetPessoasAsync();
        }

        public async Task<Pessoa> GetAsync(int id)
        {
            return await _repository.GetPessoaAsync(id);
        }

        public async Task<Pessoa> PostAsync(NovaPessoa novaPessoa)
        {
            var pessoa = mapper.Map<Pessoa>(novaPessoa);
            return await _repository.postPessoaAsync(pessoa);
        }

        public async Task<Pessoa> UpdateAsync(AlterarPessoa alterarPessoa)
        {
            var pessoa = mapper.Map<Pessoa>(alterarPessoa);

            return await _repository.updatePessoaAsync(pessoa);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeletePessoaAsync(id);
        }
    }
}
