using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WepApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendMessageController : ControllerBase
    {
        private readonly ISendMessageServcie _sendMessageServcie;

        public SendMessageController(ISendMessageServcie sendMessageServcie)
        {
            _sendMessageServcie = sendMessageServcie;
        }
        [HttpGet]
        public IActionResult SendMessageList()
        {
            var values = _sendMessageServcie.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult SendMessage(SendMessage sendMessage)
        {
            _sendMessageServcie.TInsert(sendMessage);
            return Ok("Ekleme Başarılı Oldu");
        }
        [HttpDelete]
        public IActionResult DeleteSendMessage(int id)
        {
            var values = _sendMessageServcie.TGetById(id);
            _sendMessageServcie.TDelete(values);
            return Ok("Silme İşlemi Gerçekleşti");

        }
        [HttpPut]
        public IActionResult UpdateSendMessage(SendMessage sendMessage)
        {

            _sendMessageServcie.TUpdate(sendMessage);
            return Ok("Güncelleme İşlemi Gerçekleşti");
        }
        [HttpGet("{id}")]
        public IActionResult GetBySendMessageId(int id)
        {
            var values = _sendMessageServcie.TGetById(id);
            return Ok(values);
        }
        [HttpGet("(GetSendMessageCount)")]
        public IActionResult GetSendMessageCount()
        {
            var values = _sendMessageServcie.TGetSendMessageCount();
            return Ok(values);
        }
    }
}
