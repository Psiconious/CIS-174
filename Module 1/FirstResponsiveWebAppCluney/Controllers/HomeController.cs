using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstResponsiveWebAppCluney.Models;

namespace FirstResponsiveWebAppCluney.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Result = "";
            return View();
        }
        [HttpPost]
        public IActionResult Index(ResponsiveModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Result = model.AgeThisYear();
            }
            else
            {
                ViewBag.Result = "";
            }
            return View(model);
        }
    }
}
