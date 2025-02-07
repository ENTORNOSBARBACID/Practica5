using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Practica5.Models;
using Practica5.Repositorios;

namespace Practica5.Controllers
{
    public class CursoController : Controller
    {
        private readonly ICiclos ciclos;
        private readonly IAlumno alumnos;
        private readonly ICursos cursos;

        public CursoController(ICiclos ciclos, IAlumno alumno, ICursos cursos)
        {
            this.ciclos = ciclos;
            this.alumnos = alumno;
            this.cursos = cursos;
        }

        public IActionResult Details(string siglas)
        {
            CicloDetailView c = new CicloDetailView()
            {
                ciclo = this.ciclos.findCiclo(siglas),
                Alumnos = this.alumnos.findAlumnos(siglas),
                Cursos = this.cursos.findCurso(siglas)
            };

            return View("Details", c);
        }
        public IActionResult addCurso(string siglas)
        {
            Ciclos ciclo = this.ciclos.findCiclo(siglas);

            return View(ciclo);
        }
        public IActionResult Aceptar(string Ciclo, int Curso, string Aula, int Id)
        {
            Cursos c = new Cursos(Ciclo, Curso, Aula, Id);
            this.cursos.createCurso(c);
            return RedirectToAction("Index", "Home");
        }
    }
}
