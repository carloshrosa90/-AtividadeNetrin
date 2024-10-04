using System.ComponentModel.DataAnnotations;

namespace Netrin.teste.Data.autenticacao.login
{
	public class login
	{
        [Required(ErrorMessage = "Úsuário é obrigatório")]
        public string? str_usuario { get; set; }
		[Required(ErrorMessage = "Senha é obrigatório")]
		public string? str_senha { get; set; }
    }
}
