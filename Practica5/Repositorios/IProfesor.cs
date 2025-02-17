using Practica5.Models;
    
    namespace Practica5.Repositorios
{
    public interface IProfesor
    {
        public Task<Profesor> GetProfesor(string email);
        public Task Register(Profesor p);
        public List<Profesor> findProfesor(string siglas);
    }
}
