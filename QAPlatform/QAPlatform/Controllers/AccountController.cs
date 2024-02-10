 using Microsoft.AspNetCore.Mvc;

namespace QAPlatform.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
