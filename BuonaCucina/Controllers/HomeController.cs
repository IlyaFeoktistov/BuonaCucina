using Microsoft.AspNetCore.Mvc;

namespace BuonaCucina.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
