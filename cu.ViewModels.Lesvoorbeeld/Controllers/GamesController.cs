using cu.ViewModels.Core.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace cu.ViewModels.Lesvoorbeeld.Controllers
{
    public class GamesController : Controller
    {
        private readonly GameRepository _gamerepository = new();
        public IActionResult Index()
        {
            //get the games
            var games = _gamerepository.GetGames();
            //pass to the view
            //ViewData dictionary to pass data to the view
            ViewData["PageTitle"] = "Our Games";
            ViewBag.PageTitle = "Our new Games";
            return View(games);
        }
    }
}
