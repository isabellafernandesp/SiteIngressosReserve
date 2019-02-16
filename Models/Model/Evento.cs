using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Models.Model
{
    [Table("Evento")]
    public class Evento
    {
        #region Propriedades do Evento

        [Key]
        public int Id { get; set; }
        [Required]
        public string TituloEvento { get; set; }
        [Required]
        public string DescricaoEvento { get; set; }
        [Required]
        public DateTime DataHoraEvento { get; set; }
        [Required]
        public int TotalIngressos { get; set; }

        public int TotalVendidos { get; set; }
        [Required]
        public float ValorIngresso { get; set; }

        #endregion
    }
}