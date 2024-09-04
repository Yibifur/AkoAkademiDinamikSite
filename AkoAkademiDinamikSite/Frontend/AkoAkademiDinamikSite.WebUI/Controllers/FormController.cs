using AkoAkademiDinamikSite.DtoLayer.Dtos.FormElementDtos;
using AkoAkademiDinamikSite.EntityLayer.ReelConcrete;
using AkoAkademiDinamikSite.WebUI.Models.Content;
using AkoAkademiDinamikSite.WebUI.Models.Form;
using AkoAkademiDinamikSite.WebUI.Models.FormElement;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace AkoAkademiDinamikSite.WebUI.Controllers
{
    public class FormController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public FormController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:7029/api/Forms");
            if (responseMessage.IsSuccessStatusCode)
            {

                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<FormViewModel>>(jsonData);
                return View(values);

            }
            return View();
        }
        [HttpGet]
        public IActionResult AddForm()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddForm(AddFormViewModel model)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(model);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync($"http://localhost:7029/api/Forms", stringContent);
            if (responseMessage.IsSuccessStatusCode) { return RedirectToAction("Index"); }
            return View();
        }
        public async Task<IActionResult> DeleteForm(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"http://localhost:7029/api/Forms?id={id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");

            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> UpdateForm(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:7029/api/Forms/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateFormViewModel>(jsonData);
                return View(values);

            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateForm(UpdateContentViewModel model)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync($"http://localhost:7029/api/Forms/", content);
            if (responseMessage.IsSuccessStatusCode) { return RedirectToAction("Index"); }
            return View();


        }
        [HttpGet]
        public async Task<IActionResult> EditForm(int id)
        {
            AddFormElementViewModel f = new AddFormElementViewModel();
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:7029/api/Forms/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
               var  form = JsonConvert.DeserializeObject<Form>(jsonData);
                TempData["Form"]= form;
                ViewBag.Kayit= form;
                f.FormId = form.FormId;
            }

            return View(f);
        }
        [HttpPost]
        public async Task<IActionResult> EditForm(AddFormElementViewModel model)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(model);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync($"http://localhost:7029/api/FormElements", stringContent);
            if (responseMessage.IsSuccessStatusCode) { return RedirectToAction("EditForm","Form"); }
            return View();
        }
        


    }
}
