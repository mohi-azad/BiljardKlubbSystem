
using Microsoft.AspNetCore.Mvc;
using Laboration_2.Models;
namespace Laboration_2.Controllers
{
    public class MemberController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View("Add_Member");
        }
        [HttpPost]
        public IActionResult Add(Member member)
        {
            member.MemberID = AppData.Members.Count + 1;
            AppData.Members.Add(member);
            return RedirectToAction("List");
        }
        public IActionResult List()
        {
            return View(AppData.Members);
        }
    }
}

