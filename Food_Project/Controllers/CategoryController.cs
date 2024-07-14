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
		public IActionResult GetCategory(int id)
		{
			var result = _categoryRepository.GetT(id);
			Category ct = new Category()
			{
				CategoryId=result.CategoryId, 
				CategoryName=result.CategoryName,
				CategoryDescription=result.CategoryDescription,
			};
			return View(ct);
		}
		public IActionResult UpdateCategory(Category category)
		{
			var item = _categoryRepository.GetT(category.CategoryId);
			item.CategoryId = category.CategoryId;
			item.CategoryName = category.CategoryName;
			item.CategoryDescription = category.CategoryDescription;
			item.Status = category.Status;
			_categoryRepository.UpdateT(item);
			return RedirectToAction("Index");
		}
		public IActionResult DeleteCategory(int id)
		{
			var item=_categoryRepository.GetT(id);
			item.Status = false;
			_categoryRepository.UpdateT(item);
			return RedirectToAction("Index");
		}
	}
}
