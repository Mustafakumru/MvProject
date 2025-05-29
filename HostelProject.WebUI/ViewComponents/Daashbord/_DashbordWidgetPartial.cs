using HostelProject.WebUI.Dtos.GuestDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HostelProject.WebUI.ViewComponents.Daashbord
{
    public class _DashbordWidgetPartial: ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DashbordWidgetPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5147/api/DashbordWidget/StaffCount");
           
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                //var values = JsonConvert.DeserializeObject<List<ResultGuestDto>>(jsondata);
              ViewBag.v=jsondata;

            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client.GetAsync("http://localhost:5147/api/DashbordWidget/BookingCount");

            var jsondata2 = await responseMessage2.Content.ReadAsStringAsync();
            //var values = JsonConvert.DeserializeObject<List<ResultGuestDto>>(jsondata);
            ViewBag.v2 = jsondata2;
            var client3 = _httpClientFactory.CreateClient();
            var responseMessage3 = await client.GetAsync("http://localhost:5147/api/DashbordWidget/GuestCount");

            var jsondata3 = await responseMessage3.Content.ReadAsStringAsync();
            //var values = JsonConvert.DeserializeObject<List<ResultGuestDto>>(jsondata);
            ViewBag.v3 = jsondata3;
            var client4 = _httpClientFactory.CreateClient();
            var responseMessage4 = await client.GetAsync("http://localhost:5147/api/DashbordWidget/UserCount");

            var jsondata4 = await responseMessage4.Content.ReadAsStringAsync();
            //var values = JsonConvert.DeserializeObject<List<ResultGuestDto>>(jsondata);
            ViewBag.v4 = jsondata4;
            return View();
        }
    }
}
