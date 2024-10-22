using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Guilherme_Freitas.Data
{
    public class ProvaDbContextFactory : IDesignTimeDbContextFactory<ProvaDbContext>
    {
        public ProvaDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ProvaDbContext>();
            optionsBuilder.UseSqlite("Data Source=Prova.db");

            return new ProvaDbContext(optionsBuilder.Options);
        }
    }
}
    