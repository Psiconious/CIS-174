using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Main_Site.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        public IActionResult List(string cat = "All")
        {
            return Content("Product controller, List action, Category: " + cat);
        }

        public IActionResult Detail(int id)
        {
            return Content("Product controller, Detail action, id: " + id);
        }

        public string GetSlug(string name)
        {
            return name.Replace(' ', '-').ToLower();
        }
    }
}
