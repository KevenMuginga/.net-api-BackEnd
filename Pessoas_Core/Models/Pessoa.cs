using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoas_Core.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Estado { get; set; } = 1;
        public string Nif { get; set; }
        public string Morada { get; set; }
        public string Nacionalidade { get; set; }
    }
}
