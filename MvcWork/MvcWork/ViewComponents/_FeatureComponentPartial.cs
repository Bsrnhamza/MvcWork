using Microsoft.AspNetCore.Mvc;
using MvcWork.DAL.Context;

namespace MvcWork.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        MyContext portfolioContext = new MyContext();
        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Features.ToList();
            return View(values);
        }
    }
}
