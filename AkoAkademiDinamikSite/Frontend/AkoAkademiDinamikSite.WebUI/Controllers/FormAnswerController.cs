using AkoAkademiDinamikSite.DataAccessLayer.Concrete;
using AkoAkademiDinamikSite.EntityLayer.ReelConcrete;
using AkoAkademiDinamikSite.WebUI.Models.Form;
using AkoAkademiDinamikSite.WebUI.Models.FormResponse;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AkoAkademiDinamikSite.WebUI.Controllers
{
    public class FormAnswerController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
     
        public FormAnswerController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            
        }
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:7029/api/FormAnswers");
            if (responseMessage.IsSuccessStatusCode)
            {

                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<FormAnswer>>(jsonData);
                
                return View(values);

            }
            return View();
        }
        
    }
}
