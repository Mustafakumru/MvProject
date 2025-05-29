using HostelProject.WebUI.Dtos.ContactDto;
using HostelProject.WebUI.Dtos.MeesageCategoryDto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Net.Http;

namespace HostelProject.WebUI.Controllers
{
    public class ContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;   //httpclient ooluşur bununla apiye istek gönderebilirim  
        public ContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5147/api/MessageCategory");
           
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsondata);
                 List<SelectListItem> values2 = (from x in values 
                                        select new SelectListItem
                                        { Text = x.MessageCategoryName,
                                           Value = x.MessageCategoryID.ToString() }).ToList();
                ViewBag.values2 = values2;
                return View();
     
        
        }
       

        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }
        [HttpPost]
        public async Task<IActionResult> SendMessage(CreateContactDto createContactDto)
        {
            createContactDto.Date=DateTime.Parse(DateTime.Now.ToLongDateString());  
             var client = _httpClientFactory.CreateClient();
            var jsondata = JsonConvert.SerializeObject(createContactDto);
            StringContent stringContent = new StringContent(jsondata, System.Text.Encoding.UTF8, "application/json");
            Console.WriteLine(jsondata);
            var responsemessage = await client.PostAsync("http://localhost:5147/api/Contact", stringContent);
            return RedirectToAction("Index", "Default");
        }
    }
}
