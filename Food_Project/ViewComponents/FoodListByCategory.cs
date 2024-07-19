using Food_Project.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Food_Project.ViewComponents
{
	public class FoodListByCategory : ViewComponent
	{
		private readonly FoodRepository _foodRepository;

		public FoodListByCategory(FoodRepository foodRepository)
		{
			_foodRepository = foodRepository;
		}

		public IViewComponentResult Invoke(int id)
		{
			//id = 1;
			var flist = _foodRepository.List(x => x.CategoryId == id);
			return View(flist);
		}
	}
}
