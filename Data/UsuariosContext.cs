using Microsoft.EntityFrameworkCore;
using Biblioteca.Models;

namespace Biblioteca.Data
{
    public class UsuariosContext : DbContext
    {
        public UsuariosContext (DbContextOptions<UsuariosContext> options)
            : base(options)
        {
        }

        public DbSet<Usuarios> Usuarios { get; set; }
    }
}