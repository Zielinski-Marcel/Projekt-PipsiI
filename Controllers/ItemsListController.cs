using Microsoft.AspNetCore.Mvc;
using PPSI3.Data;
using PPSI3.ViewModels;

namespace PPSI3.Controllers
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
            var ItemsAtributes = context.ItemsAtributes.ToList();
            var Items = context.Items.ToList();
            //MergeDB
            List<ItemsListViewModel> ItemsList = ItemsListViewModel.GenerateListOfItems(Items, ItemsAtributes);
            return View(ItemsList);
        }
    }
}
