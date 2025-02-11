using Practica5.Models;
namespace Practica5.Repositorios
{
    public interface IAlumno
    {
        public List<Alumno> GetAlumnos();
        public List<Alumno> findAlumnos(string s);
        public void deleteAlumnos(List<Alumno> al);
        public void addAlumno(Alumno al);
    }
}
