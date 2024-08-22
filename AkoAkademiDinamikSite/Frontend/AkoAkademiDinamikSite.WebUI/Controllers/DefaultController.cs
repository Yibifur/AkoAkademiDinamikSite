using Microsoft.AspNetCore.Mvc;

namespace AkoAkademiDinamikSite.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
