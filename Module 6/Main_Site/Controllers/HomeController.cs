using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Main_Site.Models;

namespace Main_Site.Controllers
{
    public class HomeController : Controller
    {
        private CountryContext context;

        public HomeController(CountryContext ctx)
        {
            context = ctx;
        }

        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("/About")]
        public IActionResult About()
        {
            ViewBag.CustomerName = "John";
            return View();
        }

        public ViewResult Countries(string activeGame = "all", string activeSport = "all")
        {
            ViewBag.ActiveGame = activeGame;
            ViewBag.ActiveSport = activeSport;

            List<Game> games = context.Games.ToList();
            List<Sport> sports = context.Sports.ToList();

            games.Insert(0, new Game { GameID = "all", GameName = "All" });
            sports.Insert(0, new Sport { SportID = "all", SportName = "All", SportType = "All"});

            ViewBag.Games = games;
            ViewBag.Sports = sports;

            IQueryable<Country> query = context.Countries;
            if (activeGame != "all")
            {
                query = query.Where(t => t.GameID.GameID.ToLower() == activeGame.ToLower());
            }
            if (activeSport != "all")
            {
                query = query.Where(t => t.SportID.SportID.ToLower() == activeSport.ToLower());
            }
            var teams = query.ToList();
            return View(teams);
        }
    }
}
