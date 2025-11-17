using Microsoft.AspNetCore.Mvc;
using Laboration_2.Models;

namespace Laboration_2.Controllers
{
    public class TournamentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Add(Tournament tournament)
        {
            tournament.TournamentID = AppData.Tournaments.Count + 1;
            AppData.Tournaments.Add(tournament);
            return RedirectToAction("List");
        }

        public IActionResult List()
        {
            return View(AppData.Tournaments);
        }
    }
}
