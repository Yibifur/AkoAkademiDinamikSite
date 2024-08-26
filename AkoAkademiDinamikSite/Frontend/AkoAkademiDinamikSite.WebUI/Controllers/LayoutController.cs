using AkoAkademiDinamikSite.DataAccessLayer.Concrete;
using AkoAkademiDinamikSite.WebUI.Models.Layout;
using Humanizer;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace AkoAkademiDinamikSite.WebUI.Controllers
{
    public class LayoutController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly AkoContext _context;
        public LayoutController(IHttpClientFactory httpClientFactory, AkoContext context)
        {
            _httpClientFactory = httpClientFactory;
            _context = context;
        }
        public void SetDefaultLayout(int layoutId)
        {
            var layouts = _context.Layouts.ToList();

            foreach (var layout in layouts)
            {
                layout.IsDefault = layout.LayoutId == layoutId;
            }

            _context.SaveChanges();
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:7029/api/Layouts");
            if (responseMessage.IsSuccessStatusCode)
            {
                var settings = new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore, // Döngüleri göz ardı eder
                    PreserveReferencesHandling = PreserveReferencesHandling.Objects, // Döngüsel referansları yönetir
                    MaxDepth = 64 // Derinlik problemi yaşıyorsanız artırabilirsiniz
                };

                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var layouts = JsonConvert.DeserializeObject<List<LayoutViewModel>>(jsonData, settings);
                //var model = Layouts.Select(Layout => ConvertToViewModel(Layout)).ToList();
                return View(layouts);

            }
            return View();
        }
        [HttpGet]
        public IActionResult AddLayout()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddLayout(AddLayoutViewModel model)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(model);
            StringContent stringLayout = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync($"http://localhost:7029/api/Layouts", stringLayout);
            if (responseMessage.IsSuccessStatusCode) { return RedirectToAction("Index"); }
            return View();
        }
        public async Task<IActionResult> Deletelayout(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"http://localhost:7029/api/Layouts?id={id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");

            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> UpdateLayout(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:7029/api/Layouts/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateLayoutViewModel>(jsonData);
                return View(values);

            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateLayout(UpdateLayoutViewModel model)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(model);
            StringContent layout = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync($"http://localhost:7029/api/Layouts/", layout);
            if (responseMessage.IsSuccessStatusCode) { return RedirectToAction("Index"); }
            return View();


        }
        [HttpGet]
        public async Task<IActionResult> SetLayout(int id)
        {
            
            var client = _httpClientFactory.CreateClient();
            SetDefaultLayout(id);
            var responseMessage = await client.GetAsync($"http://localhost:7029/api/Layouts/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();

                var values = JsonConvert.DeserializeObject<LayoutViewModel>(jsonData);
                TempData["LayoutModel"] = JsonConvert.SerializeObject(values); 
                //ViewBag.LayoutModel = values;
                return RedirectToAction("Index");

            }
            return View();
        }
        
    }
}
