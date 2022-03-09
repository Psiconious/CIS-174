using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Main_Site.Models;

namespace Main_Site.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Student()
        {
            return View();
        }
        public IActionResult StudentList(int id)
        {
            ViewBag.AccessLevel = id;
            ViewBag.StudentList = new List<Student>
            {
                new Student("Sam","Hill", 'A'),
                new Student("John", "Whick", 'C'),
                new Student("Billy", "Mays", 'D')
            };
            return View();
        }
    }
}
