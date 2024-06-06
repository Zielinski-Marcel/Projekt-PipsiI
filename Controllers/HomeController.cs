using Microsoft.AspNetCore.Mvc;
using PoroCounter2.Data;
using PoroCounter2.Models;
using PoroCounter2.ViewModels;
using System.Diagnostics;

namespace PoroCounter2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DB context;
        public HomeController(ILogger<HomeController> logger, DB context)
        {
            _logger = logger;
            this.context = context;
        }

        public IActionResult Index()
        {  
            _logger.LogInformation("Home page accessed");
           
            var Champions = context.Champions.ToList();
            return View(Champions);
        }

        [HttpPost]
        public IActionResult BestChampionAgainst(string name, string Role)
        {
            //DB
            var ChampionsAtributes = context.ChampionsAtribute.ToList();
            var Champions = context.Champions.ToList();
            var ChampionsRoles = context.ChampionsRole.ToList();
            //MergeDB
            List<ChampionsListViewModel> Champs = ChampionsListViewModel.GenerateListOfChampions(Champions, ChampionsAtributes, ChampionsRoles);
            //Filter
            Champs = ChampionsAtribute.RoleFilter(Champs, Role);

            ChampionsAtribute enemyLaner = ChampionsAtribute.getChampionsAtributeById(Champion.getChampionIdByName(name, Champions), ChampionsAtributes);
            var ViewModel = new BestChampionAgainst
            {
                BestChampions = ChampionsAtribute.SelectChampionAgainstLaner(enemyLaner, Champs, Champions),
                SelectedChampion = Champion.getChampionByName(name, Champions)
            };
            _logger.LogInformation("Counter for " + name + " searched!");
            return View(ViewModel);
        }

        [HttpGet]
        public JsonResult GetChampionSuggestions(string query)
        {
            var suggestions = context.Champions
                .Where(c => c.Name.Contains(query))
                .Select(c => new { c.Name, c.Photo })
                .ToList();
            return Json(suggestions);
        }

        public IActionResult Privacy()
        {
            _logger.LogInformation("Privacy page accessed");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
