using Practica5.Models;
namespace Practica5.Models
{
    public class CicloDetailView
    {
        public Ciclos ciclo { get; set; }
        public List<Cursos> Cursos { get; set; }

        public List<Alumno> Alumnos { get; set; }
    }
}
