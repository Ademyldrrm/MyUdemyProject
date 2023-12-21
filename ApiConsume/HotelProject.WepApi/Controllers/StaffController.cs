using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WepApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        IStaffService _staffService;

        public StaffController(IStaffService staffService)
        {
            _staffService = staffService;
        }
        [HttpGet]
        public IActionResult StaffList()
        {
            var values = _staffService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddStaf(Staff staff)
        {
            _staffService.TInsert(staff);
            return Ok("Ekleme Başarılı Oldu");
        }
        [HttpDelete]
        public IActionResult DeleteStaf(int id) 
        {
            var values = _staffService.TGetById(id);
            _staffService.TDelete(values);
            return Ok("Silme İşlemi Gerçekleşti");
               
        }
        [HttpPut]
        public IActionResult UpdateStaf(Staff staff) 
        {
           
            _staffService.TUpdate(staff);
            return Ok("Güncelleme İşlemi Gerçekleşti");
        }
        [HttpGet("{id}")]
        public IActionResult GetByStaffId(int id)
        {
            var values = _staffService.TGetById(id); 
            return Ok(values);
        }
    
    [HttpGet("Last4Staff")]
    public IActionResult Last4Staff()
    {
        var values = _staffService.TLast4StaffList();
        return Ok(values);
    }

}
}
