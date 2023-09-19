using LoginASPNetCore6.Services;
using Microsoft.AspNetCore.Mvc;

namespace LoginASPNetCore6.Controllers
{
    [Route("account")]
    public class AccountController : Controller
    {

        private AccountService _accountService;

        public AccountController(AccountService accountService)
        {
            _accountService = accountService;
        }

        [Route("")]
        [Route("~/")]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("login")]
        public IActionResult Login(string username, string password)
        {
            var account = _accountService.Login(username, password);
            if(account != null)
            {
                HttpContext.Session.SetString("username", username);
                return RedirectToAction("welcome");
            } else
            {
                ViewBag.msg = "Invalid";
                return View("Index");
            }
        }

        [Route("welcome")]
        public IActionResult Welcome()
        {
            ViewBag.username = HttpContext.Session.GetString("username");
            return View();
        }

        [Route("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("username");
            return View();
        }
    }
}
