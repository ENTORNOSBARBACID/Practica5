using Practica5.Models;
using Microsoft.EntityFrameworkCore;
namespace Practica5.tables

{
    public class EscuelaContext: DbContext
    {
        public EscuelaContext(DbContextOptions<EscuelaContext> options):base(options) { }
        public DbSet<Ciclos> ciclos { get; set; }
        public DbSet<Cursos> cursos { get; set; }
        public DbSet<Alumno> alumno { get; set; }
    }
}
