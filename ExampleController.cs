using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DailyBlogger.Controllers
{
    public class ExampleController : Controller
    {
        public IActionResult ShowMeAPage()
        {
            return View();  
        }

        public IActionResult ShowMeAnError()
        {
            return NotFound();
        }

        public IActionResult GiveMeAFile()
        {
            return File("/mydoc.txt", "text/plain");
        }

        public IActionResult GiveMeSomeJason()
        {
            string jsondata = "{Name: John-luc Picard, Rank: Captain, Starship: Enterprise}";

            return Json(jsondata);
        }

        public IActionResult TakeMeToGoogle()
        {
            return Redirect("https://google.com");
        }
    }
}
