using DutchTreat.ViewModels;
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
        public IActionResult Contact(ContactViewModel model) {
            if (ModelState.IsValid) { 
                // send email
                _mailService.SendMail("mattwright@yahoo.com", model.Subject, $"From: {model.Name}, {model.Email}, Message: {model.Message}")
            }
            return View();
        }




        [HttpGet("about")]
        public IActionResult About() {
            ViewBag.Title = "About Us";
            return View();
        }



    }
}
