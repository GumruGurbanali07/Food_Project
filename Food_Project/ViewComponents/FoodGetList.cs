using Food_Project.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Food_Project.ViewComponents
{
	public class FoodGetList : ViewComponent
	{
		private readonly FoodRepository _foodRepository;

		public FoodGetList(FoodRepository foodRepository)
		{
			_foodRepository = foodRepository;
		}

		public IViewComponentResult Invoke()
		{
			var res = _foodRepository.ListT();
			return View(res);
		}
	}
}
