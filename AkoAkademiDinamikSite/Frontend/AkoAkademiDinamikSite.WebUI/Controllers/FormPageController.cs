using AkoAkademiDinamikSite.EntityLayer.ReelConcrete;
using AkoAkademiDinamikSite.WebUI.Models.Page;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AkoAkademiDinamikSite.WebUI.Controllers
{
    public class FormPageController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public FormPageController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
       
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();

            var responseMessage = await client.GetAsync($"http://localhost:7029/api/Forms/GetDefaultForm");
            if (responseMessage.IsSuccessStatusCode)
            {
               

                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var form = JsonConvert.DeserializeObject<Form>(jsonData);
                
                return View(form);
            }
            return View();
        }
    }
}
