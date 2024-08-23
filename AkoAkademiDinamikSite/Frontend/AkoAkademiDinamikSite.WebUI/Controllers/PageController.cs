using AkoAkademiDinamikSite.EntityLayer.ReelConcrete;
using AkoAkademiDinamikSite.WebUI.Models.Page;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AkoAkademiDinamikSite.WebUI.Controllers
{
    public class PageController : Controller
    {
        
        private readonly IHttpClientFactory _httpClientFactory;

        public PageController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public PageViewModel ConvertToViewModel(Page page)
        {
            return new PageViewModel
            {
                PageId = page.PageId,
                ContentId = page.ContentId,
                MenuOrder = page.MenuOrder,
                Content = page.Content // Eğer Content de bir ViewModel ise ayrıca dönüştürmek gerekebilir
            };
        }
        public AddPageViewModel ConvertToAddPageViewModel(Page page)
        {
            return new AddPageViewModel
            {
                
                ContentId = page.ContentId,
                MenuOrder = page.MenuOrder,
                // Eğer Content de bir ViewModel ise ayrıca dönüştürmek gerekebilir
            };
        }
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:7029/api/Pages");
            if (responseMessage.IsSuccessStatusCode)
            {
                var settings = new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore, // Döngüleri göz ardı eder
                    PreserveReferencesHandling = PreserveReferencesHandling.Objects, // Döngüsel referansları yönetir
                    MaxDepth = 64 // Derinlik problemi yaşıyorsanız artırabilirsiniz
                };

                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var pages = JsonConvert.DeserializeObject<List<Page>>(jsonData,settings);
                var model = pages.Select(page => ConvertToViewModel(page)).ToList();
                return View(model);

            }
            return View();
        }
        [HttpGet]
        public IActionResult AddPage()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddPage(AddPageViewModel model)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(model);
            StringContent stringPage = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync($"http://localhost:7029/api/Pages", stringPage);
            if (responseMessage.IsSuccessStatusCode) { return RedirectToAction("Index"); }
            return View();
        }
        public async Task<IActionResult> DeletePage(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"http://localhost:7029/api/Pages?id={id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");

            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> UpdatePage(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:7029/api/Pages/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdatePageViewModel>(jsonData);
                return View(values);

            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdatePage(UpdatePageViewModel model)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(model);
            StringContent Page = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync($"http://localhost:7029/api/Pages/", Page);
            if (responseMessage.IsSuccessStatusCode) { return RedirectToAction("Index"); }
            return View();


        }
    }
}
