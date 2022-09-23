using Microsoft.AspNetCore.Mvc;

namespace BuonaCucina.Controllers
{
	public class RecipesController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
