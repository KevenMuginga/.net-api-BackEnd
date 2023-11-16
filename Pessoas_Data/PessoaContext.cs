using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Pessoas_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoas_Data
{
    public class PessoaContext: DbContext
    {
        public PessoaContext(DbContextOptions<PessoaContext> options): base(options)
        {
        }

        public DbSet<Pessoa> Pessoas { get; set; }
    }
}
