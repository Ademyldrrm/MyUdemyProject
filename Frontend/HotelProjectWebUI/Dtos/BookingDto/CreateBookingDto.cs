﻿namespace HotelProjectWebUI.Dtos.BookingDto
{
    public class CreateBookingDto
    {
        public string Name { get; set; }
        public string Mail { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }
        public int AdultCount { get; set; }
        public int ChildCount { get; set; }
        public int RoomCount { get; set; }
        public string SpecialReguest { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
    }
}
