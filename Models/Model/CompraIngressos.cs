using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Models.Model
{
    [Table("CompraIngressos")]
    public class CompraIngressos
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int IdUsuario { get; set; }
        [Required]
        public int IdEvento { get; set; }
        [Required]
        public int IdCartaoUsuario { get; set; }
        [Required]
        public int QtdIngressos { get; set; }
        [Required]
        public int QtdParcelas { get; set; }

        public float ValorTotal { get; set; }
    }
}