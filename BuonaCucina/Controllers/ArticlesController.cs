using Microsoft.AspNetCore.Mvc;

namespace BuonaCucina.Controllers
{
	public class ArticlesController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
