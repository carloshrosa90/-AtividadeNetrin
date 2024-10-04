using Microsoft.EntityFrameworkCore;
using WebApplication1.Controllers.model;

namespace WebApplication1.Data
{
    public class PessoaContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

    }
}
