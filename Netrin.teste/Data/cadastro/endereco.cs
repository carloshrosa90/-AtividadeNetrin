namespace Netrin.teste.Data.cadastro
{
	public class endereco
	{
		public int? id_endereco { get; set; } = 0;
		public string? str_cep { get; set; }
		public string? str_endereco { get; set; }
		public string? str_rua { get; set; }
		public int? int_numero { get; set; } = null;
        public string? str_cidade { get; set; }
        public string?  str_estado  { get; set; }
    }
}
