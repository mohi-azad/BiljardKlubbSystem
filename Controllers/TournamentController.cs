using Microsoft.AspNetCore.Mvc;
using Laboration_2.Models;
namespace Laboration_2.Controllers
{
    public class TournamentController : Controller
    {
        
        [HttpGet]
        public IActionResult Add()
        {
            return View("Add_Tournament");
        }
        [HttpPost]
        public IActionResult Add(Tournament tournament, string StartTime)
        {
            tournament.StartTime = TimeSpan.Parse(StartTime);
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
