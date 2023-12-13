﻿using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WepApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }
        [HttpGet]
        public IActionResult ServiceList()
        {
            var values = _bookingService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddBooking(Booking booking)
        {
            _bookingService.TInsert(booking);
            return Ok("Ekleme Başarılı Oldu");

        }
        [HttpDelete]
        public IActionResult DeleteBooking(int id)
        {
            var values = _bookingService.TGetById(id);
            _bookingService.TDelete(values);
            return Ok("Silme İşlemi Gerçekleşti");

        }
        [HttpPut("update")]
        public IActionResult UpdateBooking(Booking booking)
        {

            _bookingService.TUpdate(booking);
            return Ok("Güncelleme İşlemi Gerçekleşti");
        }
        [HttpGet("{id}")]
        public IActionResult GetByBookingId(int id)
        {
            var values = _bookingService.TGetById(id);
            return Ok(values);
        }
        [HttpPut("aaa")]
        public IActionResult aaa(Booking booking)
        {
            _bookingService.TBookingStatusChangeApproved(booking);
            return Ok();
        }
        [HttpPut("bbb")]
        public IActionResult bbb(Booking booking)
        {
            _bookingService.TBookingStatusChangeApproved(booking);
            return Ok();
        }




    }
}

    

