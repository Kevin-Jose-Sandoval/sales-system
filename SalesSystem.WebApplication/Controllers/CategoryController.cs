using Microsoft.AspNetCore.Mvc;

namespace SalesSystem.WebApplication.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
