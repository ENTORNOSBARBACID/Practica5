using Practica5.Models;
namespace Practica5.Repositorios
{
    public interface ICiclos
    {
        public List<Ciclos> getCiclos();
        public Ciclos findCiclo(string siglas);
        public void createCiclos(Ciclos c);

    }
}
