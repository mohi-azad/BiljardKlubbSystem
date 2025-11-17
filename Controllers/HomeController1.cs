using Microsoft.AspNetCore.Mvc;

namespace Laboration_2.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
