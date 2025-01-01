using Microsoft.AspNetCore.Mvc;
using MvcWork.DAL.Context;

namespace MvcWork.ViewComponents
{
    public class _SkillComponentPartial : ViewComponent
    {
        MyContext context = new MyContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Skills.ToList();
            return View(values);
        }
    }
}
