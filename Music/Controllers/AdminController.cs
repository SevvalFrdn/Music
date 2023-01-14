using Microsoft.AspNetCore.Mvc;

namespace Music.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
