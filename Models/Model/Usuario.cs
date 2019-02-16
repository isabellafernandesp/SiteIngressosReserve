using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Models.Model
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Informe o Nome")]
        [DisplayName("Nome")]
        [StringLength(100, ErrorMessage = "O campo Nome permite no máximo 100 caracteres.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Informe o CPF")]
        [DisplayName("CPF")]
        [StringLength(11, ErrorMessage = "O campo CPF permite no máximo 11 caracteres.")]
        public string CPF { get; set; }
        [Required(ErrorMessage = "Informe a Data de Nascimento")]
        [DisplayName("Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }
        [Required(ErrorMessage="Informe o Sexo")]
        [Column(TypeName = "char")]
        [MaxLength(1)]
        public string Sexo { get; set; }
        [Required(ErrorMessage = "Informe o Endereco")]
        [DisplayName("Endereco")]
        [StringLength(150, ErrorMessage = "O campo Endereço permite no máximo 150 caracteres.")]
        public string Endereco { get; set; }
        [Required(ErrorMessage = "Informe o Bairro")]
        [DisplayName("Bairro")]
        [StringLength(100, ErrorMessage = "O campo Bairro permite no máximo 100 caracteres.")]
        public string BairroEndereco { get; set; }
        [Required(ErrorMessage = "Informe a Cidade")]
        [DisplayName("Cidade")]
        [StringLength(100, ErrorMessage = "O campo Cidade permite no máximo 100 caracteres.")]
        public string CidadeEndereco { get; set; }
        [Required(ErrorMessage = "Informe o CEP")]
        [DisplayName("CEP")]
        [StringLength(9, ErrorMessage = "O campo CEP permite no máximo 9 caracteres.")]
        public string CEPEndereco { get; set; }
        [Required(ErrorMessage = "Informe o Email")]
        [DisplayName("Email")]
        [StringLength(100)]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email inválido.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Informe a Senha")]
        [DisplayName("Senha")]
        public string Senha { get; set; }
    }
}