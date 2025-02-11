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
            if(a is null)
            {
                
                return null;
            }
            return a;
               

        }

        public void deleteAlumnos(List<Alumno> al)
        {
            if (al is not null)
            {
                foreach (var i in al)
                {
                    this._context.alumno.Remove(i);
                }
                this._context.SaveChanges();
            }
        }

        public void addAlumno(Alumno al)
        {
            this._context.alumno.Add(al);
            this._context.SaveChanges();
        }
    }
}
