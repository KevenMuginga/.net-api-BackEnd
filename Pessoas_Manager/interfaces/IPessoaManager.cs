using Pessoas_Core.Models;
using Pessoas_CoreShared.Pessoa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoas_Manager.interfaces
{
    public interface IPessoaManager
    {
        Task DeleteAsync(int id);
        Task<IEnumerable<Pessoa>> GetAsync();
        Task<Pessoa> GetAsync(int id);
        Task<Pessoa> PostAsync(NovaPessoa novaPessoa);
        Task<Pessoa> UpdateAsync(AlterarPessoa alterarPessoa);
    }
}
