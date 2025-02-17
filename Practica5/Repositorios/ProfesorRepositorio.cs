using Microsoft.EntityFrameworkCore;
using Practica5.Models;
using Practica5.tables;

namespace Practica5.Repositorios
{
    public class ProfesorRepositorio : IProfesor
    {
        private EscuelaContext _context;

        public ProfesorRepositorio(EscuelaContext context)
        {
            _context = context;
        }

        public List<Profesor> findProfesor(string siglas)
        {
            return this._context.profesor.Where(i=>i.Ciclo==siglas).ToList();
        }

        public async Task<Profesor> GetProfesor(string email)
        {
            return await this._context.profesor.FirstOrDefaultAsync(e => e.Email == email);
        }

        public async Task Register(Profesor p)
        {
            this._context.profesor.AddAsync(p);
            await this._context.SaveChangesAsync();
        }
    }
}
