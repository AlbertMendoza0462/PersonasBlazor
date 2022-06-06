using PersonasBlazor.Models;
using Microsoft.EntityFrameworkCore;

namespace PersonasBlazor.DAL
{
    public class Contexto:DbContext
    {
        public DbSet<Personas> personas { get; set; }
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

    }
}
