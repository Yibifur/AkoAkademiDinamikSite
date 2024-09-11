using AkoAkademiDinamikSite.DataAccessLayer.Concrete;
using AkoAkademiDinamikSite.EntityLayer.ReelConcrete;
using AkoAkademiDinamikSite.WebUI.Models.FormResponse;
using AkoAkademiDinamikSite.WebUI.Models.Page;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Text;

namespace AkoAkademiDinamikSite.WebUI.Controllers
{
    public class FormPageController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly AkoContext _context;
        public FormPageController(IHttpClientFactory httpClientFactory, AkoContext context)
        {
            _httpClientFactory = httpClientFactory;
            _context = context;
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
        
        [HttpPost]
        public async Task<IActionResult> SaveFormResponses(List<FormAnswer> formAnswers)
        {
            if (formAnswers != null && formAnswers.Any())
            {
                var client = _httpClientFactory.CreateClient();

                
                List<Task<HttpResponseMessage>> responseTasks = formAnswers.Select(answer =>
                {
                    var jsonData = JsonConvert.SerializeObject(answer);
                    StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
                    return client.PostAsync("http://localhost:7029/api/FormAnswers", stringContent);
                }).ToList();

               
                var responses = await Task.WhenAll(responseTasks);

                // Tüm yanıtların başarılı olup olmadığını kontrol et
                if (responses.All(response => response.IsSuccessStatusCode))
                {
                    
                    return RedirectToAction("Index");
                }
            }

            // Hatalı durumda tekrar form sayfasını göster
            ModelState.AddModelError("", "Form kaydedilirken bir hata oluştu.");
            return Ok();
        }


    }
}
