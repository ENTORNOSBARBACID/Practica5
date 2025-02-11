using Practica5.Models;
using Practica5.tables;

namespace Practica5.Repositorios
{
    public class CiclosRepositorio:ICiclos 
    {

        private EscuelaContext _context;

        public CiclosRepositorio(EscuelaContext context)
        {
            _context = context;
        }
        public List<Ciclos> getCiclos()
        {
            var x = this._context.ciclos.ToList();
            return x;
        }
        public Ciclos findCiclo(string siglas)
        {
            return this._context.ciclos.FirstOrDefault<Ciclos>(c => c.Siglas == siglas);
        }
        public void createCiclos(Ciclos c)
        {
            this._context.ciclos.Add(c);
            this._context.SaveChanges();
        }

        public void deleteCiclo(Ciclos c)
        {

                this._context.ciclos.Remove(c);
            this._context.SaveChanges();
        }
    }
}
