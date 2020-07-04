using Microsoft.AspNetCore.Mvc;
using portfolio_site.Models;
using System.Diagnostics;

namespace portfolio_site.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "PLace holder data about yourself";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Contact info, maybe cell and email... plus github";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
