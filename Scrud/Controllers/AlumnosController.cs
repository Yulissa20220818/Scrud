using Microsoft.AspNetCore.Mvc;

namespace Scrud.Controllers
{
    public class AlumnosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
