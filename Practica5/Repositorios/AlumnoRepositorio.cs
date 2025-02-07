using Practica5.tables;
using Practica5.Models;
namespace Practica5.Repositorios
{
    public class AlumnoRepositorio:IAlumno
    {
        private EscuelaContext _context;

        public AlumnoRepositorio(EscuelaContext context)
        {
            _context = context;
        }
        public List<Alumno> GetAlumnos() {
            var a = new List<Alumno>();
            return a;
        } 
        public List<Alumno> findAlumnos (string s)
        {
           List<Alumno> a=this._context.alumno.Where<Alumno>(a => a.Ciclo == s).ToList();
            if(a.Count == 0)
            {
                
                return null;
            }
            return a;
               

        }
    }
}
