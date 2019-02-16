using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Models.Model
{
    [Table("CartaoUsuario")]
    public class CartaoUsuario
    {
        #region Propriedades do CartaoUsuario
        [Key]
        public int Id { get; set; }
        
        [Required]
        public int IdUsuario { get; set; }
        [Required]
        public string NumeroCartao { get; set; }
        [Required]
        public string NomeImpressoCartao { get; set; }
        [Required]
        public string ValidadeCartao { get; set; }
        [Required]
        public string CVVCartao { get; set; }

        #endregion
    }
}