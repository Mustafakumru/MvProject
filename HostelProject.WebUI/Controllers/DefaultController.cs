using HostelProject.WebUI.Dtos.AboutDto;
using HostelProject.WebUI.Dtos.SubscribeDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HostelProject.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;   //httpclient ooluşur bununla apiye istek gönderebilirim  
        public DefaultController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult _subscribePartial()
        {
            return PartialView();
        }
        [HttpPost]
        public async Task<IActionResult> _subscribePartial(CreateSubscribeDto createSubscribeDto)
        {
         
            var client = _httpClientFactory.CreateClient();
            var jsondata=JsonConvert.SerializeObject(createSubscribeDto);
            StringContent stringContent = new StringContent(jsondata,System.Text.Encoding.UTF8,"application/json");
            var responsemessage = await client.PostAsync("http://localhost:5147/api/Subscribe", stringContent);
           return RedirectToAction("Index","Default");
          
        }
    }
}
