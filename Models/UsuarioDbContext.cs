using Microsoft.EntityFrameworkCore;

namespace API_BASICA.Models
{
    public class UsuarioDbContext : DbContext
    {   
        public UsuarioDbContext(DbContextOptions <UsuarioDbContext> options)
        : base(options)
        { }
        public DbSet <Usuarios> Usuarios { get; set; }
    }
}