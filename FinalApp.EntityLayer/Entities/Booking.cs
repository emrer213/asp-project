﻿namespace FinalApp.EntityLayer.Entities
{
    public class Booking
    {
        public int BookingId { get; set; }
        public string BookingName { get; set; }
        public string BookingPhone { get; set; }
        public string BookingMail { get; set; }
        public string BPersonCount { get; set; }
        public DateTime Bookingdate { get; set; }
    }
}