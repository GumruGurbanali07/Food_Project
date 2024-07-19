using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Food_Project.Controllers
{
	public class TemaController : Controller
	{
		[AllowAnonymous]
		public IActionResult Index()
		{
			return View();
		}
		[AllowAnonymous]
		public IActionResult CategoryDetails(int id)
		{
			ViewBag.x = id;
			return View();
		}
	}
}
