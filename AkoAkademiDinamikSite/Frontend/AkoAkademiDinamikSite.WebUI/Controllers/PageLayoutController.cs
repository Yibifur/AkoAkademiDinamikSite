using Microsoft.AspNetCore.Mvc;

namespace AkoAkademiDinamikSite.WebUI.Controllers
{
    public class PageLayoutController : Controller
    {
        public IActionResult _MainLayout()
        {
            return View();
        }
        public PartialViewResult HeadPartial()
        {
            return PartialView();
        }
        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }
        public PartialViewResult FooterPartial()
        {
            return PartialView();
        }
        public PartialViewResult ScriptPartial()
        {
            return PartialView();
        }
    }
}
