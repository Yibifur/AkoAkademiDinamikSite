using AkoAkademiDinamikSite.WebUI.Models.Content;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NuGet.Packaging.Signing;
using System.Net.Http;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json;

namespace AkoAkademiDinamikSite.WebUI.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ArticleController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task< IActionResult> Index()
        {
           var client= _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:7029/api/Contents");
            if (responseMessage.IsSuccessStatusCode) {

                var jsonData= await responseMessage.Content.ReadAsStringAsync();
                var values= JsonConvert.DeserializeObject<List<ContentViewModel>>(jsonData);
                return View(values);
            
            }
            return View();
        }
        [HttpGet]
        public IActionResult AddContent()
        {
            return View();  
        }
        [HttpPost]
        public async Task<IActionResult> AddContent(AddContentViewModel model)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData=JsonConvert.SerializeObject(model);
            StringContent stringContent= new StringContent(jsonData,Encoding.UTF8,"application/json");
            var responseMessage = await client.PostAsync($"http://localhost:7029/api/Contents",stringContent);
            if (responseMessage.IsSuccessStatusCode) { return RedirectToAction("Index"); }
            return View();
        }
        public async Task<IActionResult> DeleteContent(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"http://localhost:7029/api/Contents?id={id}");
            if (responseMessage.IsSuccessStatusCode) { 
            return RedirectToAction("Index");
            
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> UpdateContent(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:7029/api/Contents/{id}");
            if (responseMessage.IsSuccessStatusCode) { 
            var jsonData=await responseMessage.Content.ReadAsStringAsync();
                var values=JsonConvert.DeserializeObject<UpdateContentViewModel>(jsonData);
                return View(values);
            
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateContent(UpdateContentViewModel model)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData=JsonConvert.SerializeObject(model);
           StringContent content = new StringContent(jsonData,Encoding.UTF8,"application/json");
            var responseMessage = await client.PutAsync($"http://localhost:7029/api/Contents/", content);
            if (responseMessage.IsSuccessStatusCode) { return RedirectToAction("Index"); }
            return View();

            
        }
    }
}
