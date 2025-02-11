using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Practica5.Models;
using Practica5.Repositorios;

namespace Practica5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICiclos data;
        private readonly ICursos data2;
        private readonly IAlumno data3;

        public HomeController(ICiclos _Data, ICursos _Curso, IAlumno _Alumno)
        {
            this.data = _Data;
            this.data2 = _Curso;
            this.data3 = _Alumno;
        }

        public IActionResult Index()
        {
            List<Ciclos> list = new List<Ciclos>();
            list=this.data.getCiclos();
            return View(list);
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Aceptar(string Codigo, string Siglas, string Nombre, int Cursos)
        {
            Ciclos ciclos = new Ciclos(Codigo, Siglas, Nombre, Cursos);
            data.createCiclos(ciclos);
            return RedirectToAction("index");
        }
        public IActionResult Delete(string siglas)
        {
            Ciclos c=this.data.findCiclo(siglas);
            List<Cursos> cur = this.data2.findCurso(siglas);
            List<Alumno> al=this.data3.findAlumnos(siglas);

            this.data2.deleteCurso(cur);
            this.data3.deleteAlumnos(al);
            this.data.deleteCiclo(c);

            return RedirectToAction("index");
        }
    }
}
