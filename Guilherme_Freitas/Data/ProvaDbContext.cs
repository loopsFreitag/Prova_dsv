using Microsoft.EntityFrameworkCore;
using Guilherme_Freitas.Models;

namespace Guilherme_Freitas.Data
{
    public class ProvaDbContext : DbContext
    {
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Folha> Folhas { get; set; }

        public ProvaDbContext(DbContextOptions<ProvaDbContext> options)
            : base(options) { }

            

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);
        }
    }
}