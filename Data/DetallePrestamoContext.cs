
using Microsoft.EntityFrameworkCore;
using Biblioteca.Models;

namespace Biblioteca.Data
{
    public class DetallePrestamoContext : DbContext
    {
        public DetallePrestamoContext (DbContextOptions<DetallePrestamoContext> options)
            : base(options)
        {
        }

        public DbSet<DetallePrestamo> DetallePrestamo { get; set; }
    }
}