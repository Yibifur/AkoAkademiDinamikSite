﻿using Microsoft.AspNetCore.Mvc;

namespace AkoAkademiDinamikSite.WebUI.ViewComponents.Default
{
    public class _HeadPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
