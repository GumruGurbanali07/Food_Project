using Food_Project.Models;
using Food_Project.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Food_Project.Controllers
{
	public class FoodController : Controller
	{
		private readonly FoodRepository _foodRepository;

		public FoodController(FoodRepository foodRepository)
		{
			_foodRepository = foodRepository;
		}

		public IActionResult Index()
		{
			var item = _foodRepository.TList("Category");
			return View(item);
		}
		[HttpGet]
		public IActionResult AddFood()
		{
			return View();
		}
		[HttpPost]
		public IActionResult AddFood(Food food)
		{
			return View();
		}
	}
}
