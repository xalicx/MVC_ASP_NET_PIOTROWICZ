using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;


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
