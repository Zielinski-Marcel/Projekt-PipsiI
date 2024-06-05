using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PPSI.Models;
using PPSI3.Data;
using PPSI3.ViewModels;

namespace PPSI3.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<Summoner> _userManager;
        private readonly SignInManager<Summoner> _signInManager;
        private readonly DB context;


        public AccountController(UserManager<Summoner> userManager,
            SignInManager<Summoner> signInManager,
            DB context)
        {
            context = context;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Login()
        {
            var response = new LoginViewModel();
            return View(response);
        }

       

    }
}
