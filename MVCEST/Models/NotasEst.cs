using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVCEST.Models
{
    public partial class NotasEst
    {
        [DisplayName("Id")]
        public int IdNotasEst { get; set; }
        [DisplayName ("Carnet")]
        [Required]
        public string? Carnet { get; set; }
        [DisplayName("Apellido")]
        [Required]
        public string? Apellido { get; set; }
        [DisplayName("Nombres")]
        [Required]
        public string? Nombre { get; set; }
        [DisplayName("I Parcial")]
        [Required]
        [Range (0,35)]
        public short? Ipn { get; set; }
        [DisplayName("II Parcial")]
        [Range(0, 35)]
        public short? Iipn { get; set; }
        [DisplayName ("Sistemático")]
        [Range  (0,30)]
        public short? Sist { get; set; }
        [DisplayName("Proyecto")]
        [Range(0, 35)]
        public short? Proyec { get; set; }
        [DisplayName("Nota Final")]
        public short? Nf { get; set; }
    }
}
