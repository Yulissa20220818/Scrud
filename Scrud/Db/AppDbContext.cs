using Microsoft.EntityFrameworkCore;
using Scrud.Models;

namespace Scrud.Db
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Alumnos> Alumnos { get; set; }

    }
}
