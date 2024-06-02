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
        public IActionResult ChampionCounters(string name)
        {
            var ChampionsAtributes = context.ChampionsAtribute.ToList();
            var Champions = context.Champions.ToList();
            int championId = Champion.getChampionIdByName(name, Champions);
            Champion enemy = Champion.getChampionById(championId,Champions);
            string championPhoto = Champion.getChampionPhotoByName(name, Champions);
            ChampionsAtribute enemyLaner = ChampionsAtribute.getChampionsAtributeById(championId, ChampionsAtributes);
            List<Champion> bestChampions = ChampionsAtribute.SelectChampionAgainstLaner(enemyLaner, ChampionsAtributes, Champions);
            var ViewModel = new ChampionCounterViewModel
            {
                BestChampions = bestChampions,
                SelectedChampion = enemy
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
