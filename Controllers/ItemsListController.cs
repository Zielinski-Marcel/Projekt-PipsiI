using Microsoft.AspNetCore.Mvc;
using PoroCounter2.Data;
using PoroCounter2.ViewModels;

namespace PoroCounter2.Controllers
{
    public class ItemsListController : Controller
    {
        private readonly DB context;
        public ItemsListController(DB context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            try { 
            var ItemsAtributes = context.ItemsAtributes.ToList();
            var Items = context.Items.ToList();
            //MergeDB
            List<ItemsListViewModel> ItemsList = ItemsListViewModel.GenerateListOfItems(Items, ItemsAtributes);
            return View(ItemsList);
            }
            catch (Exception ex) { return RedirectToAction("Error", "Home"); }
        }
    }
}
