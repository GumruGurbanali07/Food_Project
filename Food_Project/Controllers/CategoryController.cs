using Food_Project.DTOs;
using Food_Project.Models;
using Food_Project.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Food_Project.Controllers
{
	public class CategoryController : Controller
	{
		private readonly CategoryRepository _categoryRepository;

		public CategoryController(CategoryRepository categoryRepository)
		{
			_categoryRepository = categoryRepository;
		}

		public IActionResult Index()
		{
			var item = _categoryRepository.ListT();
			return View(item);
		}
		[HttpGet]
		public IActionResult AddCategory()
		{
			return View();
		}
		[HttpPost]
		public IActionResult AddCategory(AddCategoryDto categoryDto)
		{
			if(!ModelState.IsValid)
			{               
                return View(categoryDto); 
            }
			Category category = new Category()
			{
				CategoryName = categoryDto.CategoryName,
				CategoryDescription = categoryDto.CategoryDescription,
			};
			_categoryRepository.AddT(category);
			return RedirectToAction("Index");
		}
	}
}
