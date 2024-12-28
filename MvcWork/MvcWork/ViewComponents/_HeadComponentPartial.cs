using Microsoft.AspNetCore.Mvc;

namespace MvcWork.ViewComponents
{
    public class _HeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
        return View(); 
        }

    }
}
