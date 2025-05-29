using HostelProject.WebUI.Dtos.BookingDto;
using HostelProject.WebUI.Dtos.SubscribeDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;

namespace HostelProject.WebUI.Controllers
{
    public class BookingController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;   //httpclient ooluşur bununla apiye istek gönderebilirim  
        public BookingController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult AddBooking()
        {
            return PartialView();
        }
        [HttpPost]
        public async Task<IActionResult> AddBooking(ResultAddBookingDto resultAddBookingDto)
        {
            resultAddBookingDto.Descripton = "string ";
            resultAddBookingDto.Status = "Onay Bekliyor";
            var client = _httpClientFactory.CreateClient();
            var jsondata = JsonConvert.SerializeObject(resultAddBookingDto);
            StringContent stringContent = new StringContent(jsondata, System.Text.Encoding.UTF8, "application/json");
            Console.WriteLine(jsondata);
            var responsemessage = await client.PostAsync("http://localhost:5147/api/Booking", stringContent);
            return RedirectToAction("Index", "Booking");
        }
    }
}
