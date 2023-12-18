using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;

namespace HotelProjectWebUI.Controllers
{
    public class AdminFileController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task< IActionResult> Index(IFormFile file)
        {
            var stream=new MemoryStream();
            await file.CopyToAsync(stream);
            var bytes=stream.ToArray();
            ByteArrayContent content = new ByteArrayContent(bytes);
            content.Headers.ContentType = new MediaTypeHeaderValue(file.ContentType);
            MultipartFormDataContent multipartFormDataContent = new MultipartFormDataContent();
            multipartFormDataContent.Add(content, "file", file.FileName);
            var httpclient=new HttpClient();
            var responseMessage = await httpclient.PostAsync("https://localhost:7235/api/FileImage", multipartFormDataContent);
           
            return View();
        }
    }
}
