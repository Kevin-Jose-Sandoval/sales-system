using Microsoft.AspNetCore.Mvc;

namespace SalesSystem.WebApplication.Controllers
{
    public class BusinessController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
