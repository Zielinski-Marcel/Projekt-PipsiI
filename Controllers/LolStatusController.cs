using Microsoft.AspNetCore.Mvc;
using PoroCounter2.Models;
using PoroCounter2.Services;
using System.Composition;

namespace PoroCounter2.Controllers
{
    public class LolStatusController : Controller
    {
        private readonly LolAPIService _lolApiService;

        public LolStatusController(LolAPIService lolApiService)
        {
            _lolApiService = lolApiService;
        }

        public async Task<IActionResult> IndexAsync()
        {
            try
            {
                var platformData = await _lolApiService.GetPlatformDataAsync();
                return View(platformData);
            } catch (Exception ex) {return RedirectToAction("Error", "Home"); }

        }
    }
}
