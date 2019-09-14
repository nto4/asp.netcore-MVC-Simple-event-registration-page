using System.Linq;
using CourseAPp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseAPp.Controllers {
    public class CourseController : Controller {
        //action metodu eklenmesi
        //localhost:5000/Course/Index
        public IActionResult Index () {
            return View ();
        }
        //action metodu eklenmesi   
        //localhost:5000/Course/List 
        public IActionResult List () 
        {
            var students = Repository.Students.Where(i=>i.Confirm==true); 
            return View (students);
        }

        [HttpGet]
        public IActionResult Apply()
        {
          return View();
        }
        [HttpPost]
         public IActionResult Apply(Student student)
        {
        if(ModelState.IsValid){
        Repository.AddStudent(student);
        return View("Thanks", student);
        }
        else
        {
            return View(student);
        }
        }
        public IActionResult Details () {
            var course = new Course();
            course.Name = "Core MVC  kursu";
            course.description ="iyidir hoştur";
            course.isPublished = true;
            return View(course);
        }
    }
}