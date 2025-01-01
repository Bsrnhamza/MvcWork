using Microsoft.AspNetCore.Mvc;
using MvcWork.DAL.Context;
using MvcWork.DAL.Entities;

namespace MvcWork.Controllers
{
    public class StatisticController : Controller
    {
        MyContext context = new MyContext();
        public IActionResult Index()
        {
            ViewBag.v1 = context.Skills.Count();
            ViewBag.v2 = context.Messages.Count();
            ViewBag.v3 = context.Messages.Where(x => x.Isread == false).Count();
            ViewBag.v4 = context.Messages.Where(x => x.Isread == true).Count();
            return View();
        }
    }
}