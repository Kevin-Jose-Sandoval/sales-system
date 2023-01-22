using Microsoft.AspNetCore.Mvc;

namespace SalesSystem.WebApplication.Controllers
{
    public class ReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
