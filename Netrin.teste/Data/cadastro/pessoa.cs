using System.ComponentModel.DataAnnotations;

namespace Netrin.teste.Data.cadastro
{
	public class pessoa
	{
		public int id { get; set; }
		[Required(ErrorMessage = "Nome é obrigatório")]
		public string? str_nome { get; set; }
		//[Required(ErrorMessage = "Data de nascimento é obrigatório")]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? dat_nascimento { get; set; }
		[Required(ErrorMessage = "CPF é obrigatório")]
		[MinLength(length:11,ErrorMessage = "Quantidade mínima 11 caracteres")]
        [MaxLength(length: 11, ErrorMessage = "Quantidade mínima 11 caracteres")]
        public string? str_cpf { get; set; }
		public long? lon_telefone { get; set; }
		public List<endereco>? endereco { get; set; } = null;
		public string? str_email { get; set; }
		
	}
}
