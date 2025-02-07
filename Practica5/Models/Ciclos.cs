using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practica5.Models
{
    [Table("Ciclos")]
    public class Ciclos
    {
        public Ciclos(string codigo, string siglas, string nombre, int cursos)
        {
            Codigo = codigo;
            Siglas = siglas;
            Nombre = nombre;
            Cursos = cursos;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Codigo")]
        public string Codigo { get; set; }
        [Required]
        [Column("Siglas")]
        public string Siglas { get; set; }
        [Required]
        [Column("Nombre")]
        public string Nombre {  get; set; }
        [Required]
        [Column("Cursos")]
        public int Cursos {  get; set; }

    }
}
