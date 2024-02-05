using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class TrainingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
