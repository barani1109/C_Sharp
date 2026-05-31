using System;
using TrainReservationSystem.DAL;

namespace TrainReservationSystem.BAL
{
    class BookingBAL
    {
        BookingDAL bookingDAL = new BookingDAL();

        public bool BookTicket(
            long pnr,
            int userId,
            int trainNo,
            string className,
            DateTime bookingDate,
            DateTime travelDate,
            int seats,
            string seatNumbers,
            decimal totalAmount)
        {
            if (seats <= 0 || seats > 3)
            {
                Console.WriteLine("Maximum 3 seats allowed");
                return false;
            }

            int result = bookingDAL.BookTicket(
                pnr,
                userId,
                trainNo,
                className,
                bookingDate,
                travelDate,
                seats,
                seatNumbers,
                totalAmount);

            return result > 0;
        }

        public decimal GetBookingAmount(int bookingId)
        {
            return bookingDAL.GetBookingAmount(bookingId);
        }

        public void ViewBookings()
        {
            var dr = bookingDAL.ViewBookings();

            Console.WriteLine("\n=========== BOOKINGS ===========");

            while (dr.Read())
            {
                Console.WriteLine(
          "\nBooking ID   : " + dr["BookingId"] +
          "\nPNR Number   : " + dr["PNRNo"] +
          "\nTrain Name   : " + dr["TrainName"] +
          "\nFrom         : " + dr["SourceStation"] +
          "\nTo           : " + dr["DestinationStation"] +
          "\nClass        : " + dr["ClassName"] +
          "\nSeats        : " + dr["PassengerCount"] +
          "\nSeat Numbers : " + dr["SeatNumbers"] +
          "\nTravel Date  : " + Convert.ToDateTime(dr["TravelDate"]).ToShortDateString() +
          "\nAmount       : " + dr["TotalAmount"] +
          "\nStatus       : " + dr["BookingStatus"]
   

                );

                Console.WriteLine("-----------------------------------");
            }
        }
    }
}