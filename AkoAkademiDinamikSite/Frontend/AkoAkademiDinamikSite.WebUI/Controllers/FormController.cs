using AkoAkademiDinamikSite.DataAccessLayer.Concrete;
using AkoAkademiDinamikSite.DtoLayer.Dtos.FormElementDtos;
using AkoAkademiDinamikSite.EntityLayer.ReelConcrete;
using AkoAkademiDinamikSite.WebUI.Models.Content;
using AkoAkademiDinamikSite.WebUI.Models.Form;
using AkoAkademiDinamikSite.WebUI.Models.FormElement;
using AkoAkademiDinamikSite.WebUI.Models.FormOption;
using AkoAkademiDinamikSite.WebUI.Models.Layout;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;
using System.Xml.Linq;

namespace AkoAkademiDinamikSite.WebUI.Controllers
{
    public class FormController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly AkoContext _context;
        public FormController(IHttpClientFactory httpClientFactory, AkoContext context)
        {
            _httpClientFactory = httpClientFactory;
            _context = context;
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
        public async Task<IActionResult> GetFormElementById(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:7029/api/FormElements/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {

                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<FormElement>(jsonData);
                return Ok(values);

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
           
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:7029/api/Forms/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
               var  form = JsonConvert.DeserializeObject<Form>(jsonData);
                TempData["Form"]= form;
                
            }

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> EditForm(AddFormElementViewModel model)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(model);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync($"http://localhost:7029/api/FormElements", stringContent);
            if (responseMessage.IsSuccessStatusCode) {

                var jsonString = await responseMessage.Content.ReadAsStringAsync();
                var option = JsonConvert.DeserializeObject<FormElement>(jsonString);
                int formElementId = option.FormElementId; // Gerçek ID'yi alıyoruz

               
                TempData["FormElementId"] = formElementId; // Geçici olarak ID'yi saklıyoruz
               
                return RedirectToAction("EditForm","Form"); 
            }
            return View();
        }

        public async Task<IActionResult> DeleteFormElement(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"http://localhost:7029/api/FormElements?id={id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return Ok(responseMessage);

            }
            return View();
        }
        public async Task<IActionResult> GetAllFormElements(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:7029/api/FormElements/ByFormId/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {

                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<FormElement>>(jsonData);
                return Ok(values);

            }
            return View();
        }
        public void SetDefaultForm(int formId)
        {
            var Forms = _context.Forms.ToList();

            foreach (var form in Forms)
            {
                form.IsActive = form.FormId == formId;
            }

            _context.SaveChanges();
        }
        [HttpGet]
        public async Task<IActionResult> SetForm(int id)
        {

            var client = _httpClientFactory.CreateClient();
            SetDefaultForm(id);
            var responseMessage = await client.GetAsync($"http://localhost:7029/api/Forms/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();

                var values = JsonConvert.DeserializeObject<FormViewModel>(jsonData);
                TempData["FormModel"] = JsonConvert.SerializeObject(values);
                TempData["FormID"] = id;
                return RedirectToAction("Index");

            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> UpdateFormElement(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:7029/api/FormElements/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateFormElementDto>(jsonData);
                return Ok(values);

            }
            return View();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateFormElement(UpdateFormElementDto model)
        {        
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync($"http://localhost:7029/api/FormElements", content);
            if (responseMessage.IsSuccessStatusCode) { return Ok(); }
            return Ok();


        }

    }
}
