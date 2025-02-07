using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practica5.Models
{
    [Table("Alumno")]
    public class Alumno
    {
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
