using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Practica5.Models
{
    public class AlumnoCicloView
    {
    public List<Alumno> al {  get; set; }
    public string Ciclos { get; set; }

    }

}
