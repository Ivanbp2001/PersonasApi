using Microsoft.EntityFrameworkCore;
using PersonasApi.Models;
using System.Collections.Generic;

namespace PersonasApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Persona> Personas { get; set; }
    }
}
