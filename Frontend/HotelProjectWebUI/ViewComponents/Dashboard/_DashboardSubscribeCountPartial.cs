using HotelProjectWebUI.Dtos.FollwersDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProjectWebUI.ViewComponents.Dashboard
{
    public class _DashboardSubscribeCountPartial:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
           
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://instagram-profile1.p.rapidapi.com/getprofile/adem.yldrrm"),
                Headers =
    {
        { "X-RapidAPI-Key", "8c85645887msh3a89864ff8bb639p1bc7d3jsn39178563452f" },
        { "X-RapidAPI-Host", "instagram-profile1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                 ResultInstagramFollewersDto  resultInstagramFollewersDtos = JsonConvert.DeserializeObject<ResultInstagramFollewersDto>(body);
                ViewBag.v1 = resultInstagramFollewersDtos.followers;
                ViewBag.v2 = resultInstagramFollewersDtos.following;
               
            }
           
            var client2 = new HttpClient();
            var request2 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://twitter32.p.rapidapi.com/getProfile?username=nike"),
                Headers =
    {
        { "X-RapidAPI-Key", "8c85645887msh3a89864ff8bb639p1bc7d3jsn39178563452f" },
        { "X-RapidAPI-Host", "twitter32.p.rapidapi.com" },
    },
            };
            using (var response2 = await client.SendAsync(request2))
            {
                response2.EnsureSuccessStatusCode();
                var body2 = await response2.Content.ReadAsStringAsync();
                ResultTwitterFollewersDto resultTwitterFollewersDto=JsonConvert.DeserializeObject<ResultTwitterFollewersDto> (body2);
                ViewBag.v3 = resultTwitterFollewersDto.data.user_info.followers_count;
                ViewBag.v4 = resultTwitterFollewersDto.data.user_info.friends_count;
               
            }
           
            var client3 = new HttpClient();
            var request3 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://fresh-linkedin-profile-data.p.rapidapi.com/get-linkedin-profile?linkedin_url=https%3A%2F%2Fwww.linkedin.com%2Fin%2Fadem-y%25C4%25B1ld%25C4%25B1r%25C4%25B1m-0abbba233%2F&include_skills=false"),
                Headers =
    {
        { "X-RapidAPI-Key", "8c85645887msh3a89864ff8bb639p1bc7d3jsn39178563452f" },
        { "X-RapidAPI-Host", "fresh-linkedin-profile-data.p.rapidapi.com" },
    },
            };
            using (var response3 = await client3.SendAsync(request3))
            {
                response3.EnsureSuccessStatusCode();
                var body3 = await response3.Content.ReadAsStringAsync();
                ResultLinkedinFollewerDto resultLinkedinFollewerDto=JsonConvert.DeserializeObject<ResultLinkedinFollewerDto> (body3);
                ViewBag.v5 = resultLinkedinFollewerDto.data.followers_count;
            }
            return View();
        }
    }
}
