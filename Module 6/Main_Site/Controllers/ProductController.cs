using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Main_Site.Controllers
{
    public class ProductController : Controller
    {
        [Route("Products/{cat?}")]
        public IActionResult List(string cat = "All")
        {
            ViewBag.Categories = new List<string>
            {
                "Guitars", "Basses", "Drums"
            };
            return View();
        }

        public IActionResult Detail(int id)
        {
            ViewBag.ContentID = id;
            return View();
        }

        public string GetSlug(string name)
        {
            return name.Replace(' ', '-').ToLower();
        }
    }
}
