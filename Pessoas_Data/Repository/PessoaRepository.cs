using Microsoft.EntityFrameworkCore;
using Pessoas_Core.Models;
using Pessoas_Manager.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoas_Data.Repository
{
    public class PessoaRepository: IPessoaRepository
    {
        private readonly PessoaContext _context;
        public PessoaRepository(PessoaContext _context)
        {
            this._context = _context;
        }

        public async Task<IEnumerable<Pessoa>> GetPessoasAsync()
        {
            return await _context.Pessoas.AsNoTracking().ToListAsync();
        }

        public async Task<Pessoa> GetPessoaAsync(int id)
        {
            return await _context.Pessoas.AsNoTracking().SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task<Pessoa> postPessoaAsync(Pessoa pessoa)
        {
            await _context.Pessoas.AddAsync(pessoa);
            await _context.SaveChangesAsync();

            return pessoa;
        }

        public async Task<Pessoa> updatePessoaAsync(Pessoa pessoa)
        {
            var pessoaConsultada = await _context.Pessoas.FindAsync(pessoa.Id);
            if(pessoaConsultada == null)
            {
                return null;
            }

            _context.Entry(pessoaConsultada).CurrentValues.SetValues(pessoa);
            await _context.SaveChangesAsync();

            return pessoa;
        }

        public async Task DeletePessoaAsync(int id)
        {
            var pessoaConsultada = await _context.Pessoas.FindAsync(id);
            _context.Pessoas.Remove(pessoaConsultada);
            _context.SaveChangesAsync();


        }

    }
}
