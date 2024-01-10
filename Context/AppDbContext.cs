using Curso_Udemy_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Curso_Udemy_API.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Carimbo> Carimbos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

    }
}