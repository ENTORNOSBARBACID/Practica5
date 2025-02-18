using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Practica5.Models;
using Practica5.Repositorios;
using Practica5.Helpers;
using Humanizer.Bytes;
using System.Collections.Generic;

namespace Practica5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICiclos data;
        private readonly ICursos data2;
        private readonly IAlumno data3;
        private readonly IProfesor data4;

        public HomeController(ICiclos _Data, ICursos _Curso, IAlumno _Alumno, IProfesor _Profesor)
        {
            this.data = _Data;
            this.data2 = _Curso;
            this.data3 = _Alumno;
            this.data4 = _Profesor;
        }
        public IActionResult Index() {
            return View();
         }

        public async Task<IActionResult> Login(ProfesorLogin p) {
            Profesor prof = await this.data4.GetProfesor(p.Email);
            if (prof == null)
            {
                TempData["ErrorMessage"] = "No se ha encontrado ningún usuario con esos datos";
                return RedirectToAction("Index");
            }

            //byte[] encryptedPassword = Cifrado.EncryptPassword(p.Contraseña, prof.Salt);

            //if (!Cifrado.CompareArrays(prof.Contraseña, encryptedPassword))
            //{
            //    TempData["ErrorMessage"] = "Las credenciales son erróneas";
             //   return RedirectToAction("Index");
            //}
            HttpContext.Session.SetObject("profesor", prof);

            return RedirectToAction("Home");
        }
        public async Task<IActionResult> Register()
        {
            List<Ciclos> c=await this.data.getCiclos();
            return View(c);
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegistroProfesor p)
        {
            string Salt = Cifrado.GenerateSalt();
            byte[] cifrada = Cifrado.EncryptPassword(p.Contraseña , Salt);

            Profesor pro = new Profesor
            {
                Nombre=p.Nombre,
                Apellido=p.Apellido,
                DNI=p.DNI,
                Ciclo=p.Ciclo,
                Email=p.Email,
                Contraseña=cifrada,
                Salt=Salt,
            };

            await this.data4.Register(pro);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Home()
        {
            List<Ciclos> list = new List<Ciclos>();
            list=await this.data.getCiclos();
            return View(list);
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Aceptar(int Codigo, string Siglas, string Nombre, int Cursos)
        {
            Ciclos ciclos = new Ciclos(Codigo, Siglas, Nombre, Cursos);
            data.createCiclos(ciclos);
            return RedirectToAction("Home");
        }
        public IActionResult Delete(string siglas)
        {
            Ciclos c=this.data.findCiclo(siglas);
            List<Cursos> cur = this.data2.findCurso(siglas);
            List<Alumno> al=this.data3.findAlumnos(siglas);

            this.data2.deleteCurso(cur);
            this.data3.deleteAlumnos(al);
            this.data.deleteCiclo(c);

            return RedirectToAction("Home");
        }
    }
}
