using Pessoas_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoas_Manager.interfaces
{
    public interface IPessoaRepository
    {
        Task DeletePessoaAsync(int id);
        Task<Pessoa> GetPessoaAsync(int id);
        Task<IEnumerable<Pessoa>> GetPessoasAsync();
        Task<Pessoa> postPessoaAsync(Pessoa pessoa);
        Task<Pessoa> updatePessoaAsync(Pessoa pessoa);
    }
}
