using Microsoft.AspNetCore.Mvc;
using Laboration_2.Models;
using System.Diagnostics.CodeAnalysis;

namespace Laboration_2.Controllers
{
    public class CompetitionController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            ViewBag.Members = AppData.Members;
            ViewBag.Tournament = AppData.Tournaments;
            return View();
        }
        [HttpPost]
        public IActionResult Register(int memberID, int tournamentID, int? result)
        {
            var mc = new MemberCompetition(memberID, tournamentID, result);
            AppData.MemberCompetitions.Add(mc);
            return RedirectToAction("List");
        }

        /*
        public IActionResult CountParticipants(int tournamentsID) {
            var Count = AppData.MemberCompetitions.Count(mc => mc.TournamentID == tournamentsID);
            ViewBag.Number = Count;
            return View();
        }
        */

        public IActionResult List()
        {
            return View(AppData.MemberCompetitions);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
