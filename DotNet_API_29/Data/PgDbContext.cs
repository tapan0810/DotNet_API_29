using DotNet_API_29.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNet_API_29.Data
{
    public class PgDbContext:DbContext
    {
        public PgDbContext(DbContextOptions<PgDbContext> options):base(options)
        {
        }
        public DbSet<Pg> Pgs => Set<Pg>();
    }
}
