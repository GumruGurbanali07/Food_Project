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
            var deger1 = _context.Foods.Count();
            ViewBag.d1=deger1;  

            var deger2=_context.Categories.Count();
            ViewBag.d2=deger2;

            var fid = _context.Categories.Where(x => x.CategoryName == "Fruitss").Select(y => y.CategoryId).FirstOrDefault();
            var veg = _context.Categories.Where(x => x.CategoryName == "Vegetables").Select(y => y.CategoryId).FirstOrDefault();
            var gr = _context.Categories.Where(x => x.CategoryName == "Grain").Select(y => y.CategoryId).FirstOrDefault();


            var deger3 =_context.Foods.Where(x=>x.CategoryId==fid).Count();
            ViewBag.d3=deger3;

            var deger4=_context.Foods.Where(x=>x.CategoryId == _context.Categories.Where(y => y.CategoryName == "Fruitss").Select(z => z.CategoryId).FirstOrDefault()).Count();
            ViewBag.d4=deger4;

            var deger5 = _context.Foods.Sum(x=>x.Stock);
            ViewBag.d5=deger5;

            var deger6 = _context.Foods.Where(x => x.CategoryId == _context.Categories.Where(y => y.CategoryName == "Grain").Select(z => z.CategoryId).FirstOrDefault()).Count();
            ViewBag.d6 = deger6;


            var deger7=_context.Foods.OrderByDescending(x=>x.Stock).Select(y=>y.Name).FirstOrDefault();
            ViewBag.d7=deger7;

            var deger8 = _context.Foods.OrderBy(x => x.Stock).Select(y => y.Name).FirstOrDefault();
            ViewBag.d8 = deger8;

            var deger9 = _context.Foods.Average(x => x.Price).ToString("0.00");
            ViewBag.d9 = deger9;

            var deger10 = _context.Foods.Where(x => x.CategoryId == fid).Sum(y => y.Stock);
            ViewBag.d10 = deger10;

            var deger11 = _context.Foods.Where(x => x.CategoryId == veg).Sum(y => y.Stock);
            ViewBag.d11 = deger11;

            var deger12 = _context.Foods.Where(x => x.CategoryId == gr).Sum(y => y.Stock);
            ViewBag.d12 = deger12;
            return View();
        }
    }
}
