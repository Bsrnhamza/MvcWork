using Microsoft.AspNetCore.Mvc;

namespace MvcWork.ViewComponents
{
    public class _NavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
             return View();
        }
    }
}
