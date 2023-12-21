using HotelProjectWebUI.Dtos.AppUserDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProjectWebUI.Controllers
{
    public class ApminUserListWithWorkLocationController : Controller
    {

        IHttpClientFactory _httpClientFactory;

        public ApminUserListWithWorkLocationController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> UserList()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7235/api/AppUserWorkLocation");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultAppUserWithWorkLocationDto>>(jsonData);

                return View(values);
            }
            return View();
        }
    }
}
