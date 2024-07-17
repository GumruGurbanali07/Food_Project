using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Food_Project.Controllers
{
    public class LoginController : Controller
    {
        [AllowAnonymous] //bunu hansi action ustune yazsan hemin actiona authorize olmadan girmek mumkundur
        public IActionResult Index()
        {
            return View();
        }
    }
}
