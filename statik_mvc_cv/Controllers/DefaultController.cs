using Microsoft.AspNetCore.Mvc;

namespace statik_mvc_cv.Controllers
{
	public class DefaultController : Controller
	{
		//Get:Default
		public IActionResult Index()
		{
			return View();
		}
	}
}
