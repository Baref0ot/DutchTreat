using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.IIS.Core;

namespace DutchTreat.Controllers {
    public class AppController : Controller {

        public IActionResult Index() {
            return View();
        }



        [HttpGet("contact")]
        public IActionResult Contact() { 
            return View();
        }

        [HttpPost("contact")]
        public IActionResult Contact(object model) {
            return View();
        }




        [HttpGet("about")]
        public IActionResult About() {
            ViewBag.Title = "About Us";
            return View();
        }



    }
}
