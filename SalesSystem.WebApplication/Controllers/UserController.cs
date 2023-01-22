using Microsoft.AspNetCore.Mvc;

namespace SalesSystem.WebApplication.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
