﻿namespace HostelProject.WebUI.Dtos.BookingDto
{
    public class ResultLast6BookingsDto
    {
        public int BookingID { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }
        public string AdultCount { get; set; }
        public string ChildCount { get; set; }
        public string RoomCount { get; set; }
        public string SpecialRequest { get; set; }
        public string Descripton { get; set; }
        public string Status { get; set; }
    }
}
