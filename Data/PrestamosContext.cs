using Microsoft.EntityFrameworkCore;
using Biblioteca.Models;

namespace Biblioteca.Data
{
    public class PrestamosContext : DbContext
    {
        public PrestamosContext (DbContextOptions<PrestamosContext> options)
            : base(options)
        {
        }

        public DbSet<Prestamos> Prestamos { get; set; }
    }
}