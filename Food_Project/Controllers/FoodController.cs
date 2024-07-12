using Food_Project.Data;
using Food_Project.DTOs;
using Food_Project.Models;
using Food_Project.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Food_Project.Controllers
{
    public class FoodController : Controller
    {
        private readonly FoodRepository _foodRepository;
        private readonly AppDbContext _context;
        public FoodController(FoodRepository foodRepository, AppDbContext context)
        {
            _foodRepository = foodRepository;
            _context = context;
        }

        public IActionResult Index()
        {
            var item = _foodRepository.TList("Category");
            return View(item);
        }
        [HttpGet]
        public IActionResult AddFood()
        {
            //dropdown list
            List<SelectListItem> items = (from x in _context.Categories.ToList()
                                          select new SelectListItem
                                          {
                                              Text = x.CategoryName,
                                              Value = x.CategoryId.ToString()
                                          }).ToList();
            ViewBag.v1= items;

            return View();
        }
        [HttpPost]
        public IActionResult AddFood(AddFoodDto food)
        {
            if(!ModelState.IsValid)
            {
                List<SelectListItem> items = (from x in _context.Categories.ToList()
                                              select new SelectListItem
                                              {
                                                  Text = x.CategoryName,
                                                  Value = x.CategoryId.ToString()
                                              }).ToList();
                ViewBag.v1 = items;
                return View(food);
            }
            Food food1 = new Food()
            {
                Name = food.Name,
                LongDescription = food.LongDescription,               
                Price = food.Price,
                Stock = food.Stock,
                ImageUrl = food.ImageUrl,
                CategoryId=food.CategoryId,
            };
            _foodRepository.AddT(food1);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteFood(int id)
        {
            var item = _context.Foods.Find(id);
            _foodRepository.DeleteT(item);
            return RedirectToAction("Index");
        }
    }
}
