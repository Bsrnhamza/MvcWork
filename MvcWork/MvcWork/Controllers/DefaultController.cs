using Microsoft.AspNetCore.Mvc;

namespace MvcWork.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
