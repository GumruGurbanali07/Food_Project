using Food_Project.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Food_Project.ViewComponents
{
	public class CategoryGetList : ViewComponent
	{
		private readonly CategoryRepository _categoryRepository;

		public CategoryGetList(CategoryRepository categoryRepository)
		{
			_categoryRepository = categoryRepository;
		}

		public IViewComponentResult Invoke()
		{

			var categorylist = _categoryRepository.ListT();
			return View(categorylist);

		}
	}
}
