using Microsoft.AspNetCore.Mvc;
using MvcWork.DAL.Context;

namespace MvcWork.ViewComponents
{
    public class _ExperienceComponentPartial:ViewComponent
    {
        MyContext context = new MyContext();

        public IViewComponentResult Invoke()
        {
            var values = context.Experiences.ToList();
            return View(values);
        }
    }
}
