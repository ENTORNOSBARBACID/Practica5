﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practica5.Models
{
    [Table("Cursos")]
    public class Cursos
    {
        public Cursos(string ciclo, int curso, string aula, int id)
        {
            Ciclo = ciclo;
            Curso = curso;
            Aula = aula;
            Id = id;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Ciclo")]
     public string Ciclo {  get; set; }
        [Required]
        [Column("Curso")]
     public int Curso {  get; set; }
        [Required]
        [Column("Aula")]
        public string Aula {  get; set; }
        [Required]
        [Column("Id")]
        public int Id { get; set; }
    }
}
