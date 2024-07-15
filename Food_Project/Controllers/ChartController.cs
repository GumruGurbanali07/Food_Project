using Food_Project.Data;
using Food_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace Food_Project.Controllers
{
    public class ChartController : Controller
    {
        private readonly AppDbContext _context;

        public ChartController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index2()
        {
            return View();
        }
        public IActionResult VisualizeProduct()
        {
            return Json(ProList());
        }
       public List<Chart> ProList()
        {
            List<Chart> list = new List<Chart>();
            list.Add(new Chart
            {
                Propname = "Computer",
                Stock = 60
            });
            list.Add(new Chart
            {
                Propname = "Phone",
                Stock = 30
            });
            list.Add(new Chart
            {
                Propname="Tablet",
                Stock=15
            });
            return list;
        }
        public IActionResult Index3()
        {
            return View();
        }
        public List<FoodChart> VisualizeFoodChart()
        {
            List<FoodChart> foodCharts = new List<FoodChart>();
            foodCharts = _context.Foods.Select(x => new FoodChart
            {
                foodname = x.Name,
                stock = x.Stock,
            }).ToList();
            return foodCharts;
        }
        public IActionResult Statistics()
        {
            return View();
        }
    }
}
