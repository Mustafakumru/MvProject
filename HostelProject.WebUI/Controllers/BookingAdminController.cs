using HostelProject.WebUI.Dtos.BookingDto;
using HostelProject.WebUI.Dtos.GuestDto;
using HostelProject.WebUI.Dtos.ServiseDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace HostelProject.WebUI.Controllers
{
    public class BookingAdminController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BookingAdminController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5147/api/Booking/BookingList");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultBookingDto>>(jsondata);
                return View(values);
            }
            return View();
        }
        public async Task<IActionResult> ApprovedRezervation(ApprovedResrvationDto approvedResrvationDto)
        {
            approvedResrvationDto.Status = "Onaylandı";
            var client = _httpClientFactory.CreateClient();
            var jsondata = JsonConvert.SerializeObject(approvedResrvationDto);
            StringContent stringContent = new StringContent(jsondata, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("http://localhost:5147/api/Booking/ChangeBookingStatus", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View(approvedResrvationDto);

        }
        public async Task<IActionResult> ApprovedRezervation2(int id)
        {
           
            var client = _httpClientFactory.CreateClient();
           
            
            var responseMessage = await client.GetAsync($"http://localhost:5147/api/Booking/BookingAproved{id}");
            
                return RedirectToAction("Index");
            
        

        }
        [HttpGet]
        public async Task<IActionResult> UpdateBooking(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:5147/api/Booking/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateBookinDto>(jsondata);
                return View(values);
            }
            return View();

        }

        [HttpPost]
        public async Task<IActionResult> UpdateBooking(UpdateBookinDto updateBookinDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsondata = JsonConvert.SerializeObject(updateBookinDto);
            StringContent stringContent = new StringContent(jsondata, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("http://localhost:5147/api/Booking/UpdateBooking", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        public async Task<IActionResult>CancelRezervation(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:5147/api/Booking/BookingCancel{id}");
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> WaitRezervation(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:5147/api/Booking/BookingWait{id}");
            return RedirectToAction("Index");
        }

    }
}
