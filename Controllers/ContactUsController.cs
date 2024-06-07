using Microsoft.AspNetCore.Mvc;
using PoroCounter2.Data;
using PoroCounter2.ViewModels;

namespace PoroCounter2.Controllers
{
    public class ContactUsController : Controller
    {
        private readonly IEmailSender emailSender;
        private readonly ILogger<HomeController> _logger;
        public ContactUsController(ILogger<HomeController> logger, DB context, IEmailSender emailSender)
        {
            _logger = logger;
            this.emailSender = emailSender;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SentAsync(string email)
        {
            try
            {
                if (string.IsNullOrEmpty(email))
                {
                    ModelState.AddModelError("", "Email is required.");
                    return View("Index");
                }

                var subject = "PoroCounter Contact Us";
                var message = "Hey! Looks like you want to contact us! One of our staff members will try to get in touch with you as soon as possible. You can reply to this message to provide information about your reason for contacting us.";

                await emailSender.SendEmailAsync(email, subject, message);
                await emailSender.SendEmailToYourself(email);
                ViewBag.Email = email;
                return View();
            }
            catch (Exception ex) { return RedirectToAction("Error", "Home"); }
        }
    }
}
