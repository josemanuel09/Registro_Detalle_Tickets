using Microsoft.EntityFrameworkCore;
using Registro_Detalle_Tickets.Shared.Models;

namespace Registro_Detalle_Tickets.Api.DAL
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
        public DbSet<Tickets> Tickets { get; set; }
        public DbSet<TicketsDetalle> TicketsDetalle { get; set; }
    }
}
