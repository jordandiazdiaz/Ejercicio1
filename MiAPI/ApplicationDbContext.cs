using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace MiAPI.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Persona> Personas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Persona>().HasData(
            // Aquí puedes insertar 20 registros dummy como se especificó en la pregunta original.
            );
        }
    }

    public class Persona
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DocumentNumber { get; set; }
        public decimal Salary { get; set; }
        public int Age { get; set; }
        public string Profile { get; set; }
        public DateTime AdmissionDate { get; set; }
    }
}
