using Practica5.tables;
using Practica5.Models;
namespace Practica5.Repositorios
{
    public class AlumnoRepositorio:IAlumno
    {
        private EscuelaContext _context;

        public void RepositoryAlumnos(EscuelaContext context)
        {
            _context = context;
        }
        public List<Alumno> GetAlumnos() {
            var a = new List<Alumno>();
            return a;
        } 
        public List<Alumno> findAlumnos (string s)
        {
            return this._context.alumno.Where<Alumno>(a => a.Ciclo == s).OrderBy(a => a.Curso).ToList();
        }
    }
}
