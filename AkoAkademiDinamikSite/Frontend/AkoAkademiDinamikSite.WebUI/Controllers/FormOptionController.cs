using AkoAkademiDinamikSite.EntityLayer.ReelConcrete;
using AkoAkademiDinamikSite.WebUI.Models.Content;
using AkoAkademiDinamikSite.WebUI.Models.FormOption;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace AkoAkademiDinamikSite.WebUI.Controllers
{
    public class FormOptionController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public FormOptionController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:7029/api/FormOptions");
            if (responseMessage.IsSuccessStatusCode)
            {

                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<FormOptionViewModel>>(jsonData);
                return View(values);

            }
            return View();
        }
        public async Task<IActionResult> GetFormOptionsByFormElementId(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:7029/api/FormOptions/ByFormElementId/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {

                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<FormOptionViewModel>>(jsonData);
                return Ok(values);

            }
            return View();
        }
        [HttpGet]
        public IActionResult AddFormOption()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddFormOption(int FormElementId,string Name, string Value, int Order)
        {
            
            var formOption = new AddFormOptionViewModel
            {
                
                FormElementId= FormElementId,  
                Name = Name,
                Value = Value,
                Order = Order
            };

            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(formOption);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync($"http://localhost:7029/api/FormOptions", stringContent);

            if (responseMessage.IsSuccessStatusCode)
            {
                return Ok(Name); // Başarılı olduğunda Index'e yönlendirme yapar
            }

            // Başarısız durumda tekrar formu görüntülemek için View'a geri döner
            return Ok();
        }

        public async Task<IActionResult> DeleteFormOption(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"http://localhost:7029/api/FormOptions?id={id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return Ok();

            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> UpdateFormOption(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:7029/api/FormOptions/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateFormOptionViewModel>(jsonData);
                return View(values);

            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateFormOption(UpdateContentViewModel model)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync($"http://localhost:7029/api/FormOptions/", content);
            if (responseMessage.IsSuccessStatusCode) { return RedirectToAction("Index"); }
            return View();


        }
        //[HttpGet]
        //public async Task<IActionResult> EditFormOption(int id)
        //{

        //    var client = _httpClientFactory.CreateClient();
        //    var responseMessage = await client.GetAsync($"http://localhost:7029/api/FormOptions/{id}");
        //    if (responseMessage.IsSuccessStatusCode)
        //    {
        //        var jsonData = await responseMessage.Content.ReadAsStringAsync();
        //        var FormOption = JsonConvert.DeserializeObject<FormOption>(jsonData);
        //        TempData["FormOption"] = FormOption;

        //    }

        //    return View();
        //}
        //[HttpPost]
        //public async Task<IActionResult> EditFormOption(AddFormOptionElementViewModel model)
        //{
        //    var client = _httpClientFactory.CreateClient();
        //    var jsonData = JsonConvert.SerializeObject(model);
        //    StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
        //    var responseMessage = await client.PostAsync($"http://localhost:7029/api/FormOptionElements", stringContent);
        //    if (responseMessage.IsSuccessStatusCode) { return RedirectToAction("EditFormOption", "FormOption"); }
        //    return View();
        //}
    }
}
