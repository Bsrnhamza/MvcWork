using Microsoft.AspNetCore.Mvc;

namespace MvcWork.ViewComponents
{
    public class _StatisticComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
