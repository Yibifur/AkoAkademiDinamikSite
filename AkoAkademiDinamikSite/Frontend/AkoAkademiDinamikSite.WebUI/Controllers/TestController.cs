using AkoAkademiDinamikSite.WebUI.Dtos.ContentDtos;
using AkoAkademiDinamikSite.WebUI.Models.Page;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using System.Text.Json;
using AkoAkademiDinamikSite.EntityLayer.ReelConcrete;

namespace AkoAkademiDinamikSite.WebUI.Controllers
{
    public class TestController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public TestController(IHttpClientFactory httpClientFactory)
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
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:7029/api/Pages/");
            if (responseMessage.IsSuccessStatusCode)
            {
                var settings = new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore, // Döngüleri göz ardı eder
                    PreserveReferencesHandling = PreserveReferencesHandling.Objects, // Döngüsel referansları yönetir
                    MaxDepth = 64 // Derinlik problemi yaşıyorsanız artırabilirsiniz
                };

                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var pages = JsonConvert.DeserializeObject<List<Page>>(jsonData, settings);
                var model = pages.Select(page => ConvertToViewModel(page)).ToList();
                return View(model);
            }
            return View();
        }
    }
}
