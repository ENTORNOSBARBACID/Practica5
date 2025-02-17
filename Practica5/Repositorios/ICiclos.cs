using Practica5.Models;
namespace Practica5.Repositorios
{
    public interface ICiclos
    {
        public Task<List<Ciclos>> getCiclos();
        public Ciclos findCiclo(string siglas);
        public void createCiclos(Ciclos c);
        public void deleteCiclo(Ciclos c);
    }
}
