using Netrin.EFCore.WebApi.Controllers.model;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Netrin.EFCore.WebApi.Controllers.model
{
    public class Endereco
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string? str_nome { get; set; }
        public DateTime? dat_nascimento { get; set; }
        public string? str_cpf { get; set; }
        public long? lon_telefone { get; set; }
        public string? str_email { get; set; }
        public Pessoa Pessoa { get; set; }
        public int PessoaId { get; set; }

    }
}
