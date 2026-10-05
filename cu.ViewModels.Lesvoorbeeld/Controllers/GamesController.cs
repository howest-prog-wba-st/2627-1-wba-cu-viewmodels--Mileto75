using cu.ViewModels.Core.Repositories;
using cu.ViewModels.Lesvoorbeeld.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace cu.ViewModels.Lesvoorbeeld.Controllers
{
    public class GamesController : Controller
    {
        private readonly GameRepository _gamerepository = new();
        public IActionResult Index()
        {
            //get the game titles and show them to the user
            var games = _gamerepository.GetGames();
            //put in the view
            var gamesIndexViewModel = new GamesIndexViewModel();
            gamesIndexViewModel.Titles = new();
            //projection/transformation
            foreach(var game in games)
            {
                gamesIndexViewModel.Titles.Add(game.Title);
            }
            //pass to the view
            return View(gamesIndexViewModel);
            //ViewData dictionary to pass data to the view
            //ViewData["PageTitle"] = "Our Games";
            //ViewBag.PageTitle = "Our new Games";
            //return View(games);
        }
        public IActionResult Info(int id)
        {
            //get the game with id
            var game = _gamerepository.GetGames().FirstOrDefault(g => g.Id == id);
            //check if null
            if(game == null)
            {
                return NotFound();
            }
            //fill the viewmodel
            //projection/tranformation
            var gamesInfoViewModel = new GamesInfoViewModel
            {
                Id = game.Id,
                Title = game.Title,
                DeveloperName = game.Developer.Name
            };
            //pass to the view
            return View(gamesInfoViewModel);
        }
    }
}
