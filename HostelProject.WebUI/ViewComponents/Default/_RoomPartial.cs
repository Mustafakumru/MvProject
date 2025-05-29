using HostelProject.WebUI.Dtos.RoomDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HostelProject.WebUI.ViewComponents.Default
{
    public class _RoomPartial: ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;   //httpclient ooluşur bununla apiye istek gönderebilirim  
        public _RoomPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client=_httpClientFactory.CreateClient();
            var responsemessage = await client.GetAsync("http://localhost:5147/api/Room");
            if (responsemessage.IsSuccessStatusCode)
            {
                var jsondata=await responsemessage.Content.ReadAsStringAsync();
                var values=JsonConvert.DeserializeObject<List<ResultRoomDto>>(jsondata);
                return View(values);
            }
            return View();
        }
    }
}
