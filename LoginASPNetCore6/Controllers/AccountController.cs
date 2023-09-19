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
            } else
            {
                ViewBag.msg = "Invalid";
                return View("Index");
            }
        }
    }
}
