using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace PoroCounter2.Controllers
{
    using Microsoft.AspNetCore.Localization;
    using Microsoft.AspNetCore.Mvc;

    public class LanguageController : Controller
    {
        [HttpGet]
        public IActionResult SetLanguage(string culture)
        {
            try
            {
                Response.Cookies.Append(
                    CookieRequestCultureProvider.DefaultCookieName,
                    CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                    new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
                );
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex) { return RedirectToAction("Error", "Home"); }
        }
    }

}
