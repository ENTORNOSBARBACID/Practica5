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
        private readonly IProfesor profesor;

        public CursoController(ICiclos ciclos, IAlumno alumno, ICursos cursos, IProfesor profesor)
        {
            this.ciclos = ciclos;
            this.alumnos = alumno;
            this.cursos = cursos;
            this.profesor = profesor;
        }

        public IActionResult Details(string siglas)
        {
            CicloDetailView c = new CicloDetailView()
            {
                ciclo = this.ciclos.findCiclo(siglas),
                Alumnos = this.alumnos.findAlumnos(siglas),
                Cursos = this.cursos.findCurso(siglas),
                Profesores=this.profesor.findProfesor(siglas)
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
            return RedirectToAction("Home", "Home");
        }
        public IActionResult addAlumno(string siglas) {
            Ciclos ciclo = this.ciclos.findCiclo(siglas);
            return View(ciclo);
        }
        public IActionResult add(string DNI, string Nombre, string Apellido, int Telefono, int Edad, string Ciclo, int Curso, int id)
        {
            Alumno al=new Alumno(DNI, Nombre, Apellido, Telefono, Edad, Ciclo, Curso, id);
            this.alumnos.addAlumno(al);
            return RedirectToAction("Home", "Home");
        }
        public async Task<IActionResult> delete(string dni)
        {
            Alumno al=await this.alumnos.findAlumno(dni);
            await this.alumnos.deleteAlumno(al);
            return RedirectToAction("Home", "Home");
        }
        public async Task<IActionResult> edit(string dni)
        {
            Alumno a = await this.alumnos.findAlumno(dni);
            return View(a);
        }
        [HttpPost]
        public async Task<IActionResult> edit(editAlumno ed)
        {
            Alumno a = await this.alumnos.findAlumno(ed.DNI);
            a.Telefono = ed.Telefono;
            a.Edad = ed.Edad;
            a.Ciclo = ed.Ciclo;
            a.Curso = ed.Curso;

            await this.alumnos.editAlumno(a);
            return RedirectToAction("Home", "Home");
        }
    }
}
