using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WepApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WrokLocationController : ControllerBase
    {
        private readonly IWrokLocationService _wrokLocationService;

        public WrokLocationController(IWrokLocationService wrokLocationService)
        {
            _wrokLocationService = wrokLocationService;
        }
        [HttpGet]
        public IActionResult WorkLocationService()
        {
            var values=_wrokLocationService.TGetList();
            return  Ok(values);
        }
        [HttpPost]
        public IActionResult AddWorkLocation(WorkLocation workLocation)
        {
            _wrokLocationService.TInsert(workLocation);
            return Ok("Ekleme Başarılı Oldu");
        }
        [HttpDelete]
        public IActionResult DeleteWorkLocation(int id)
        {
            var values = _wrokLocationService.TGetById(id);
            _wrokLocationService.TDelete(values);
            return Ok("Silme İşlemi Gerçekleşti");

        }
        [HttpPut]
        public IActionResult UpdateWorkLocation(WorkLocation workLocation)
        {

            _wrokLocationService.TUpdate(workLocation);
            return Ok("Güncelleme İşlemi Gerçekleşti");
        }
        [HttpGet("{id}")]
        public IActionResult GetByWorkLocationtId(int id)
        {
            var values = _wrokLocationService.TGetById(id);
            return Ok(values);
        }
    }
}
