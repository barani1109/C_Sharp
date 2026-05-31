using System;

namespace TrainReservationSystem.Models
{
    public class Booking
    {
        public int BookingId { get; set; }

        public long PNRNo { get; set; }

        public int UserId { get; set; }

        public int TrainNo { get; set; }

       
        public string ClassName { get; set; }

        public DateTime BookingDate { get; set; }

        public DateTime TravelDate { get; set; }

        public int PassengerCount { get; set; }

        public string SeatNumbers { get; set; }

        public decimal TotalAmount { get; set; }

        public string BookingStatus { get; set; }
    }
}