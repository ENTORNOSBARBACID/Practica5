using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practica5.Models
{
    [Table("Alumno")]
    public class Alumno
    {
        private string apellidos;

        public Alumno(string DNI, string Nombre, string Apellido, int Telefono, int Edad, string Ciclo, int Curso, int id)
        {
            this.DNI = DNI;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Telefono = Telefono;
            this.Edad = Edad;
            this.Ciclo = Ciclo;
            this.Curso = Curso;
            this.id = id;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("DNI")]
        public string DNI { get; set; }
        [Required]
        [Column("Nombre")]
        public string Nombre{ get; set; }
        [Required]
        [Column("Apellidos")]
        public string Apellido { get; set; }
        [Required]
        [Column("Telefono")]
        public int Telefono {  get; set; }
        [Required]
        [Column("Edad")]
        public int Edad {  get; set; }
        [Required]
        [Column("Ciclo")]
        public string Ciclo { get; set; }
        [Required]
        [Column("Curso")]
        public int Curso {  get; set; }
        [Required]
        [Column("Id")]
        public int id {  get; set; }
    }
}
