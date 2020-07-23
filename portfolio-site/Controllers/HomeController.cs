using Microsoft.AspNetCore.Mvc;
using portfolio_site.Models;
using System.Diagnostics;

namespace portfolio_site.Controllers
{
    public class HomeController : Controller
    {
        //START TESTING STUFF
        public IActionResult Clicker()
        {
            ViewData["Message"] = "Made to test if the database connection works";
            return View();
        }
        //END TESTING STUFF


        //This is the website landing page
        public IActionResult Index()
        {
            ViewData["Message"] = "This is your basic info";
            return View();
        }

        //
        public IActionResult Testimonials()
        {
            ViewData["Message"] = "This is where testimonials live";
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Contact info for recruiters";

            return View();
        }

        public IActionResult SkillsAndExp()
        {
            ViewData["Message"] = "Long list of skills and experience";

            return View();
        }

        public IActionResult Bio()
        {
            ViewData["Message"] = "Some info about yourself";

            return View();
        }
        public IActionResult Practice()
        {
            ViewData["Message"] = "A collection of practice peices";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
