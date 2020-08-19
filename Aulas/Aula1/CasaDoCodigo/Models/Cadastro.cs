using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Models
{
    public class Cadastro : BaseModel
    {
        public Cadastro()
        {
        }

        public virtual Pedido Pedido { get; set; }

        [MinLength(5, ErrorMessage = "Nome deve ter no minimo 5 caracteres")]
        [MaxLength(50, ErrorMessage = "Nome deve ter no maximo 50 caracteres")]
        [Required(ErrorMessage = "Nome eh obrigatorio")]
        public string Nome { get; set; } = "";
        [Required(ErrorMessage = "Email eh obrigatorio")]
        public string Email { get; set; } = "";
        [Required(ErrorMessage = "Telefone eh obrigatorio")]
        public string Telefone { get; set; } = "";
        [Required(ErrorMessage = "Endereco eh obrigatorio")]
        public string Endereco { get; set; } = "";

        [Required(ErrorMessage = "Complemento eh obrigatorio")]
        public string Complemento { get; set; } = "";
        [Required(ErrorMessage = "Bairro eh obrigatorio")]
        public string Bairro { get; set; } = "";
        [Required(ErrorMessage = "Municipio eh obrigatorio")]
        public string Municipio { get; set; } = "";
        [Required(ErrorMessage = "UF eh obrigatorio")]
        public string UF { get; set; } = "";
        [Required(ErrorMessage = "CEP eh obrigatorio")]
        public string CEP { get; set; } = "";

        internal void Update(Cadastro novoCadastro)
        {
            this.Nome = novoCadastro.Nome;
            this.Email = novoCadastro.Email;
            this.Telefone = novoCadastro.Telefone;
            this.Endereco = novoCadastro.Endereco;
            this.Complemento = novoCadastro.Complemento;
            this.Bairro = novoCadastro.Bairro;
            this.Municipio = novoCadastro.Municipio;
            this.UF = novoCadastro.UF;
            this.CEP = novoCadastro.CEP;
        }
    }
}
