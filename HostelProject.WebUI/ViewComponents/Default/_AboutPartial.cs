using HostelProject.WebUI.Dtos.AboutDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HostelProject.WebUI.ViewComponents.Default
{
    public class _AboutPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;   //httpclient ooluşur bununla apiye istek gönderebilirim  
        public _AboutPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task <IViewComponentResult> InvokeAsync()
        {
            var client=_httpClientFactory.CreateClient(); //bir client oluşturuyoruz
            var responsemessage = await client.GetAsync("http://localhost:5147/api/About"); //apideki verileri alıyoruz responsemesage değişkenine
            if (responsemessage.IsSuccessStatusCode) //apiye başarılı bir şekilde ulaşıyorsak işleme başlıyoruz 
            {
                var jsonData=await responsemessage.Content.ReadAsStringAsync(); //apiden json formatında gelen veriyi string çevirimi yapıyoruz 
                var values=JsonConvert.DeserializeObject<List<ResultAboutDto>> (jsonData);  //resultabotdto tipinde listeye dönüşüyor 
                return View(values);//view de gösteriyor 
            }
            return View();
        }
    }
}
