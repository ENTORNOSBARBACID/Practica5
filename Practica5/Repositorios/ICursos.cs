using Practica5.Models;
namespace Practica5.Repositorios
{
    public interface ICursos
    {
        public List<Cursos> findCurso(string s);
        public void createCurso(Cursos c);
    }
}
