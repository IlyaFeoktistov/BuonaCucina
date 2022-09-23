using Microsoft.AspNetCore.Mvc;

namespace BuonaCucina.Controllers
{
	public class ForumController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
