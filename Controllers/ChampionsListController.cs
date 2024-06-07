using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Hosting;
using PoroCounter2.Data;
using PoroCounter2.ViewModels;

namespace PoroCounter2.Controllers
{
    public class ChampionsListController : Controller
    {
        private readonly IMemoryCache cache;
        private readonly DB context;
        public ChampionsListController(DB context, IMemoryCache cache)
        {
            this.context = context;
            this.cache=cache;
        }
        public IActionResult Index()
        {
            try
            {
                var ChampionsAtributes = cache.GetOrCreate("ChampionsAtributes", _ => context.ChampionsAtribute.ToList());
                var Champions = cache.GetOrCreate("Champions", _ => context.Champions.ToList());
                var ChampionsRoles = cache.GetOrCreate("ChampionsRoles", _ => context.ChampionsRole.ToList());
                //MergeDB
                List<ChampionsListViewModel> Champs = ChampionsListViewModel.GenerateListOfChampions(Champions, ChampionsAtributes, ChampionsRoles);

                return View(Champs);
            }
            catch (Exception ex) { return RedirectToAction("Error", "Home"); }
        }
    }
}
