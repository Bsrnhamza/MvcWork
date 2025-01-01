using Microsoft.AspNetCore.Mvc;

namespace MvcWork.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
