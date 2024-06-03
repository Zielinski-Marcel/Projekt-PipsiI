using Microsoft.AspNetCore.Mvc;
using PPSI.Nowy_folder;
using PPSI3.Models;
using PPSI3.ViewModels;
using System.Linq;

namespace PPSI3.Controllers
{
    public class ChampionCounterController : Controller
    {
        private readonly DB context;

        public ChampionCounterController(DB context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var Champions = context.Champions.ToList();
            return View(Champions);
        }

        [HttpPost]
        public IActionResult ChampionCounters(string name,string Role)
        {
            //DB
            var ChampionsAtributes = context.ChampionsAtribute.ToList();
            var Champions = context.Champions.ToList();
            var ChampionsRoles= context.ChampionsRole.ToList();
            //MergeDB
            List<ChampionsListViewModel> Champs = ChampionsListViewModel.GenerateListOfChampions(Champions, ChampionsAtributes, ChampionsRoles);
            //Filter
            Champs = ChampionsAtribute.RoleFilter(Champs, Role);

            ChampionsAtribute enemyLaner = ChampionsAtribute.getChampionsAtributeById(Champion.getChampionIdByName(name, Champions), ChampionsAtributes);
            var ViewModel = new ChampionCounterViewModel
            {
                BestChampions = ChampionsAtribute.SelectChampionAgainstLaner(enemyLaner, Champs, Champions),
                SelectedChampion = Champion.getChampionByName(name, Champions)
            };

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
    }
}
