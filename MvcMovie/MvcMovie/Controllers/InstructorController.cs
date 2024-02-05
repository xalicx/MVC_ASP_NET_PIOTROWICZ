using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class InstructorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
