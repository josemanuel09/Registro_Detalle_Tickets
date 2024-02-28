using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_Detalle_Tickets.Shared.Models
{
    public class Tickets
    {
        [Key]
        public int TicketId { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public DateTime Fecha { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Este campo es requerido")]
        public string? Asunto { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public string? Descripcion { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [StringLength(30, ErrorMessage = "No puede exceder los 30 Caracteres")]
        public string? SolicitadoPor { get; set; }

        [ForeignKey("TicketId")]
        public ICollection<TicketsDetalle> TicketsDetalle { get; set; } = new List<TicketsDetalle>();
    }
}
