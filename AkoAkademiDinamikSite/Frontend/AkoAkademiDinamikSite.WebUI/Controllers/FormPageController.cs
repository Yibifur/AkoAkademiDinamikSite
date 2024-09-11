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
            if (formAnswers == null || formAnswers.Any(answer => string.IsNullOrEmpty(answer.Value)))
            {
                ModelState.AddModelError("", "Tüm alanları doldurmanız gerekmektedir.");
                return Ok(); // Form sayfasına geri dön
            }

            var client = _httpClientFactory.CreateClient();

            foreach (var answer in formAnswers)
            {
                
                if (string.IsNullOrEmpty(answer.Value))
                {
                    ModelState.AddModelError("", "Form elemanı değerlerinden biri boş. Lütfen tüm alanları doldurun.");
                    return Ok();
                }

                
                var jsonData = JsonConvert.SerializeObject(answer);
                StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("http://localhost:7029/api/FormAnswers", stringContent);

                // Eğer cevap hatalıysa işlemi durdur ve hata mesajı döndür
                if (!response.IsSuccessStatusCode)
                {
                    ModelState.AddModelError("", "Form kaydedilirken bir hata oluştu.");
                    // Hatalı durumda form sayfasını yeniden göster
                    return Ok();
                }
            }

            // Eğer tüm işlemler başarılıysa yönlendirme yap
            return RedirectToAction("Index");
        }


    }
}
