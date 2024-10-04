using Microsoft.AspNetCore.Mvc;
using Netrin.EFCore.WebApi.Domain;

namespace Netrin.EFCore.WebApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]

    public class PessoaController : ControllerBase
    {
        public readonly PessoaContext _context;
        public PessoaController(PessoaContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public ActionResult<List<Pessoa>> Get()
        {
                try
                {
                    return Ok(_context.Pessoas.ToList());
                }
                catch (Exception)
                {
                    return BadRequest();
                }
        }

        [HttpGet("{id}")]
        public ActionResult<List<Pessoa>> GetById([FromRoute]int? id)
        {
            if (id != null)
            {
                try
                {
                    return Ok(_context.Pessoas.Where(x => x.id == id).FirstOrDefault());
                }
                catch (Exception)
                {
                    return BadRequest();
                }
            }
            else
                return NotFound();
        }

        [HttpPost(Name = "")]
        public bool Insert([FromBody] Domain.Pessoa pessoa)
        {
            try
            {
                _context.Pessoas.Add(pessoa);
                var r = _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [HttpPut("{id}")]
        public bool Update([FromBody] Pessoa pessoa, [FromRoute] int? id)
        {
            if (id == null)
                return false;

            try
            {
                var pessoaContext = _context.Pessoas.Where(x => x.id == id).FirstOrDefault();

                pessoaContext.senha = pessoa.senha;
                pessoaContext.dat_nascimento = pessoa.dat_nascimento;
                pessoaContext.usuario = pessoa.usuario;
                pessoaContext.str_email = pessoa.str_email;
                pessoaContext.lon_telefone = pessoa.lon_telefone;
                pessoaContext.str_cpf = pessoa.str_cpf;
                pessoaContext.str_nome = pessoa.str_nome;

                 pessoaContext = pessoa;
                _context.SaveChanges();
              
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [HttpDelete("{id}")]
        public bool Delete(int? id)
        {
            if (id == null)
                return false;

            try
            {
                var pessoa = _context.Pessoas.Where(x => x.id == id).FirstOrDefault();
                _context.Pessoas.Remove(pessoa);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
