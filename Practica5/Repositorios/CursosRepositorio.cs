using Practica5.Models;
using Practica5.tables;

namespace Practica5.Repositorios
{
    public class CursosRepositorio : ICursos
    {
        private EscuelaContext _context;

        public CursosRepositorio(EscuelaContext context)
        {
            _context = context;
        }

        public List<Cursos> findCurso(string s)
        {
            return this._context.cursos.Where<Cursos>(c => c.Ciclo==s).ToList();
        }
        public void createCurso(Cursos c)
        {
            this._context.cursos.Add(c);
            this._context.SaveChanges();
        }
    }
}
