using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_Detalle_Tickets.Shared.Models
{
    public class TicketsDetalle
    {
        [Key]
        public int DetalleId { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        [ForeignKey("TicketId")]
        public int TicketId { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public string? Emisor { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public string? Mensaje { get; set; }
    }
}
