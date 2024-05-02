using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RNG.Models
{
    [Table("Reserva")]
    public class Reserva
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idReserva { get; set; }

        [Required]
        public DateTime Fecha_Entrada { get; set; }

        [Required]
        public DateTime Fecha_Salida { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [ForeignKey("Email")]
        public virtual Cliente Cliente { get; set; }
    }
}
