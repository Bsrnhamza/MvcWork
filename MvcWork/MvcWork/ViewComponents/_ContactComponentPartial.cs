﻿using Microsoft.AspNetCore.Mvc;

namespace MvcWork.ViewComponents
{
    public class _ContactComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
