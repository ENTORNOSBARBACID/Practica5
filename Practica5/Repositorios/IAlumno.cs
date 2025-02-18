using Practica5.Models;
namespace Practica5.Repositorios
{
    public interface IAlumno
    {
        public List<Alumno> GetAlumnos();
        public List<Alumno> findAlumnos(string s);
        public Task<Alumno> findAlumno(string dni);
        public void deleteAlumnos(List<Alumno> al);
        public Task deleteAlumno(Alumno al);
        public void addAlumno(Alumno al);
        public Task editAlumno(Alumno al);
    }
}
