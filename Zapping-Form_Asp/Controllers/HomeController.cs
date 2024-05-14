using Microsoft.AspNetCore.Mvc;

namespace Zapping_Form_Asp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
