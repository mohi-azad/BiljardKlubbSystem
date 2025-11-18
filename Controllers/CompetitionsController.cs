using Microsoft.AspNetCore.Mvc;
using Laboration_2.Models;

namespace Laboration_2.Controllers
{
    public class CompetitionController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            ViewBag.Members = AppData.Members;
            ViewBag.Tournaments = AppData.Tournaments;
            return View();
        }
        [HttpPost]
        public IActionResult Register(int memberID, int tournamentID)
        {
            var member = AppData.Members.FirstOrDefault(m => m.MemberID == memberID);
            var tournament = AppData.Tournaments.FirstOrDefault(t => t.TournamentID == tournamentID);
            if (member == null || tournament == null)
            {
                TempData["Error"] = "Fel val på medlem eller turnering.";
                return View("Register");
            }
         
            var exists = AppData.MemberCompetition.Any(mc =>
                mc.FirstName == member.FirstName &&
                mc.LastName == member.LastName &&
                mc.TournamentType == tournament.TournamentType
            );
            if (exists)
            {
                TempData["Error"] = "Medlemmen är redan registrerad på den turneringen.";
                return RedirectToAction("Register");
            }

            var mc = new MemberCompetition(
                member.FirstName,
                member.LastName,
                member.Score,
                tournament.TournamentType
            );

            AppData.MemberCompetition.Add(mc);
            TempData["Message"] = "Deltagaren är nu registrerad.";
            return RedirectToAction("List");
        }

        
        public IActionResult List()
        {
            return View(AppData.MemberCompetition);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
