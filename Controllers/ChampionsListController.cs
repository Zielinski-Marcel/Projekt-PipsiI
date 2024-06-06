using Microsoft.AspNetCore.Mvc;
using PoroCounter2.Data;
using PoroCounter2.ViewModels;

namespace PoroCounter2.Controllers
{
    public class ChampionsListController : Controller
    {
        private readonly DB context;
        public ChampionsListController(DB context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var ChampionsAtributes = context.ChampionsAtribute.ToList();
            var Champions = context.Champions.ToList();
            var ChampionsRoles = context.ChampionsRole.ToList();
            //MergeDB
            List<ChampionsListViewModel> Champs = ChampionsListViewModel.GenerateListOfChampions(Champions, ChampionsAtributes, ChampionsRoles);
            return View(Champs);
        }
    }
}
