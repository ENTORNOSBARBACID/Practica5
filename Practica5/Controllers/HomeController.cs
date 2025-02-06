using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Practica5.Models;
using Practica5.Repositorios;

namespace Practica5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICiclos data;

        public HomeController(ICiclos _Data)
        {
            this.data = _Data;
        }

        public IActionResult Index()
        {
            List<Ciclos> list = new List<Ciclos>();
            list=this.data.getCiclos();
            return View(list);
        }
    }
}
