using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;

namespace HostelProject.WebUI.Controllers
{
    public class AdminImageFileController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(IFormFile file)
        {
            var stram=new MemoryStream();
            await file.CopyToAsync(stram);
            var bytes=stram.ToArray();
            ByteArrayContent byteArrayContent = new ByteArrayContent(bytes);
            byteArrayContent.Headers.ContentType = new MediaTypeHeaderValue(file.ContentType);
            MultipartFormDataContent multipartFormDataContent = new MultipartFormDataContent();
            multipartFormDataContent.Add(byteArrayContent,"file",file.FileName);
            var htttpclient=new HttpClient();
            var responseMessage=await htttpclient.PostAsync("http://localhost:5147/api/FileImage", multipartFormDataContent);
           return View();
        }
    }
}
