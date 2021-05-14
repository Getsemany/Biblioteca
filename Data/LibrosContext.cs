using Microsoft.EntityFrameworkCore;
using Biblioteca.Models;

namespace Biblioteca.Data
{
    public class LibrosContext : DbContext
    {
        public LibrosContext (DbContextOptions<LibrosContext> options)
            : base(options)
        {
        }

        public DbSet<Libros> Libros { get; set; }
    }
}