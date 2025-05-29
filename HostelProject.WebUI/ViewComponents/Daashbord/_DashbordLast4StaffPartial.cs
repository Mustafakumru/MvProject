using HostelProject.WebUI.Dtos.GuestDto;
using HostelProject.WebUI.Dtos.StaffDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HostelProject.WebUI.ViewComponents.Daashbord
{
    public class _DashbordLast4StaffPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DashbordLast4StaffPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5147/api/Staff/Last4Staf");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultStaffDto>>(jsondata);
                return View(values);
            }
            return View();
        }
    }
}
