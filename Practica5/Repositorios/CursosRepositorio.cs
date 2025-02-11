using Microsoft.CodeAnalysis.CSharp;
using Microsoft.EntityFrameworkCore;
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

        public void deleteCurso(List<Cursos> c)
        {
            if (c is not null)
            {
                foreach (var i in c)
                {
                    this._context.cursos.Remove(i);
                }
                this._context.SaveChanges();
            }
        }

    }
}
