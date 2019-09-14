using System;
using Microsoft.AspNetCore.Mvc;

namespace CourseAPp.Controllers {
    //Localhost:5000/Home/Index => home/index.cshtml
    public class HomeController : Controller {

        //Localhost:5000/Home/Index
        public IActionResult Index () {
            int saat = DateTime.Now.Hour;
            
           // ViewBag.Greeting = saat > 12 ? "iyi günler" : "günaydın";
            ViewBag.Message = "Xyz etkinliği kayıt sayfası ";
            return View ();
        }

        //Localhost:5000/Home/About
        public IActionResult About () {
            return View ();
        }
    }
}