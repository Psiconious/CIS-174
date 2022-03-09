using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Main_Site.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        [Route("[area]/")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("[area]/About")]
        public IActionResult About()
        {
            return View();
        }
    }
}
