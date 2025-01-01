using Microsoft.AspNetCore.Mvc;
using MvcWork.DAL.Context;

namespace MvcWork.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        MyContext portfolioContext = new MyContext();
        public IViewComponentResult Invoke()
        {          
            ViewBag.aboutTitle = portfolioContext.Abouts.Select(x => x.Title).FirstOrDefault();
            ViewBag.aboutsubDescription = portfolioContext.Abouts.Select(x => x.SubDescription).FirstOrDefault();
            ViewBag.aboutDetail = portfolioContext.Abouts.Select(x => x.Details).FirstOrDefault();
            return View();
        }
    }
}
