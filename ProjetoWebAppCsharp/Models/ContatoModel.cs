using System.ComponentModel.DataAnnotations;

namespace ProjetoWebAppCsharp.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o código.")]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "Verifique o tipo se é PF ou PJ.")]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "Digite o seu CPF ou CNPJ.")]
        public string CpfCnpj { get; set; }

        public string? RgIe { get; set; }

        [Required(ErrorMessage = "Digite o nome do contato.")]
        public string Nome { get; set; }

        public string? NomeAbreviado { get; set; }

        [Required(ErrorMessage = "Digite o CEP.")]
        public string Cep { get; set; }

        public string? Logradouro { get; set; }

        public string? Numero { get; set; }

        public string? Complemento { get; set; }

        public string? Bairro { get; set; }

        public string? Municipio { get; set; }

        public string? UnidadeFederativa { get; set; }


        [Required(ErrorMessage = "Digite o email do contato.")]
        [EmailAddress(ErrorMessage ="O email informado não é válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Digite o celular do contato.")]
        [Phone(ErrorMessage = "O celular informado não é válido.")]
        public string Celular { get; set; }

        public DateTime Inclusao { get; set; }

        public DateTime? Alteracao { get; set; }
    }
}
