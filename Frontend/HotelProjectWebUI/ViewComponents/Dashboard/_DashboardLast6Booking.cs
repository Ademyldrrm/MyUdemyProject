using HotelProjectWebUI.Dtos.BookingDto;
using HotelProjectWebUI.Dtos.StaffDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProjectWebUI.ViewComponents.Dashboard
{
    public class _DashboardLast6Booking : ViewComponent
    {

        IHttpClientFactory _httpClientFactory;

        public _DashboardLast6Booking(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7235/api/Booking/LastBooking6");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultBookingLast6Dto>>(jsonData);

                return View(values);
            }
            return View();
        }
    }
}
