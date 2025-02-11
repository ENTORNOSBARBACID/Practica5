using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Practica5.Controllers
{
    public class AlumnoController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
