using HotelProject.BusinessLayer.Abstract;
using HotelProject.DtoLayer.Dtos.AboutDto;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WepApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }
        [HttpGet]
        public IActionResult ListAbout()
        {
            var values = _aboutService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AboutAdd(CreateAboutDto createAboutDto)
        {
            About about= new About()
            {
                Title1=createAboutDto.Title1,
                Title2 = createAboutDto.Title2,
                CustomerCount=createAboutDto.CustomerCount,
                Content = createAboutDto.Content,
                RoomCount=createAboutDto.RoomCount,
                staffCount = createAboutDto.staffCount              
            };
            _aboutService.TInsert(about);
            return Ok("Hakkımızdaki bilgiler Eklendi");
        }
        [HttpPut]
        public IActionResult AboutUpdate(UpdateAboutDto updateAboutDto)
        {
            About about = new About()
            {
                AboutID=updateAboutDto.AboutID,
                Title1 = updateAboutDto.Title1,
                Title2 = updateAboutDto.Title2,
                CustomerCount = updateAboutDto.CustomerCount,
                Content = updateAboutDto.Content,
                RoomCount = updateAboutDto.RoomCount,
                staffCount = updateAboutDto.staffCount
            };
            _aboutService.TUpdate(about);
            return Ok("Günclleme İşlemi Başarılı Bir Şekilde Gerçekleşti");

        }
        [HttpDelete]
        public IActionResult DeleteAbout(int id)
        {
            var values=_aboutService.TGetById(id);
            _aboutService.TDelete(values);
            return Ok("Silme İşlemi Gerçekleşti");
        }
        [HttpGet("{id}")]
        public IActionResult GetAbout(int id)
        {
            var values = _aboutService.TGetById(id);
            return Ok(values);
        }
    }
}
