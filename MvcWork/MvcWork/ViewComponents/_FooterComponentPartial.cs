using Microsoft.AspNetCore.Mvc;

namespace MvcWork.ViewComponents
{
    public class _FooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
