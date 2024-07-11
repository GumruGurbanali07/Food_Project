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
	}
}
