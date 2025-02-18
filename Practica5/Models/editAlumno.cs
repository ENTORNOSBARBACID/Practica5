using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Practica5.Models
{
    public class editAlumno
    {
        public string DNI { get; set; }
        public int Telefono { get; set; }
        public int Edad { get; set; }
        public string Ciclo { get; set; }
        public int Curso { get; set; }
    }
}
