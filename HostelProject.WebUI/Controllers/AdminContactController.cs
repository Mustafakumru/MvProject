using HostelProject.WebUI.Dtos.ContactDto;
using HostelProject.WebUI.Dtos.InboxDto;
using HostelProject.WebUI.Models.Staff;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HostelProject.WebUI.Controllers
{
    public class AdminContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> InBox()
        {
            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client2.GetAsync("http://localhost:5147/api/SendMessage/GetSendMessageCount");
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5147/api/Contact/");
            var client3 = _httpClientFactory.CreateClient();
            var responseMessage3= await client3.GetAsync("http://localhost:5147/api/Contact/GetSendMessageCount");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                var jsondata2 = await responseMessage2.Content.ReadAsStringAsync();
                ViewBag.Inbox = jsondata2;
                var jsondata3 = await responseMessage3.Content.ReadAsStringAsync();
                ViewBag.SendBox = jsondata3;
                var values = JsonConvert.DeserializeObject<List<InboxContactDto>>(jsondata);
                return View(values);
            }
             return View();
        }
        public async Task<IActionResult> SendBox()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5147/api/SendMessage");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<SendBoxDto>>(jsondata);
                return View(values);
            }
            return View();
        }
        public PartialViewResult SidebarAdminContactPartial()
        {
            return PartialView();
        }
        public PartialViewResult SidebarAdminCategoriPartial()
        {
            return PartialView();
        }
        [HttpGet]
        public IActionResult AddSendMessage()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddSendMessage(SendMessageContactDto sendMessageContactDto)
        {
            sendMessageContactDto.SenderMail = "admin@gmail.com";
            sendMessageContactDto.SenderName = "Admin";
            sendMessageContactDto.Date =DateTime.Parse(DateTime.Now.ToShortDateString());
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(sendMessageContactDto);
            Console.WriteLine(jsonData);
            StringContent stringContent = new StringContent(jsonData, encoding: System.Text.Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("http://localhost:5147/api/SendMessage", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("AddSendMessage");
            }
            return View();
        }
        public  async Task<IActionResult> MeesageDetailsBySendBox(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:5147/api/SendMessage/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<GetMesageByID>(jsondata);
                return View(values);
            }
            return View();
        }
        public async Task<IActionResult> MeesageDetailsByInbox(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:5147/api/Contact/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<InboxContactDto>(jsondata);
                return View(values);
            }
            return View();
        }
       

    }
}
