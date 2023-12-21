using HotelProjectWebUI.Dtos.GuestDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProjectWebUI.ViewComponents.Dashboard
{
    public class _DashboardWidgetPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DashboardWidgetPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7235/api/DashboardWidget/GetStaffCount");
            var jsonData = await responseMessage.Content.ReadAsStringAsync(); 
            ViewBag.staffCount = jsonData;


            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client2.GetAsync("https://localhost:7235/api/DashboardWidget/GetBookingCount");
            var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
            ViewBag.bookingCount = jsonData2;


            var client3 = _httpClientFactory.CreateClient();
            var responseMessage3 = await client3.GetAsync("https://localhost:7235/api/DashboardWidget/GetAppUserCount");
            var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
            ViewBag.appUserCount = jsonData3;

            var client4 = _httpClientFactory.CreateClient();
            var responseMessage4 = await client4.GetAsync("https://localhost:7235/api/DashboardWidget/GetAppUserCount");
            var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
            ViewBag.roomCount = jsonData4;

            return View();
            
        }
    }
}
