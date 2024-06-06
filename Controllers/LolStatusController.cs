using Microsoft.AspNetCore.Mvc;
using PoroCounter2.Services;

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
            var platformData = await _lolApiService.GetPlatformDataAsync();
            return View(platformData);
        }
    }
}
