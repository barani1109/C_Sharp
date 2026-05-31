using System;
using System.Data.SqlClient;

namespace TrainReservationSystem.DAL
{
    class BookingDAL
    {
        public int BookTicket(
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
            SqlConnection con = DBHelper.GetConnection();

            try
            {
                string query = @"
                INSERT INTO Bookings
                (
                    PNRNo,
                    UserId,
                    TrainNo,
                    ClassName,
                    BookingDate,
                    TravelDate,
                    PassengerCount,
                    SeatNumbers,
                    TotalAmount,
                    BookingStatus
                )
                VALUES
                (
                    @pnr,
                    @uid,
                    @tno,
                    @cname,
                    @bdate,
                    @tdate,
                    @seats,
                    @seatNumbers,
                    @amount,
                    'Booked'
                )";

                SqlCommand cmd =
                    new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@pnr", pnr);
                cmd.Parameters.AddWithValue("@uid", userId);
                cmd.Parameters.AddWithValue("@tno", trainNo);
                cmd.Parameters.AddWithValue("@cname", className);
                cmd.Parameters.AddWithValue("@bdate", bookingDate);
                cmd.Parameters.AddWithValue("@tdate", travelDate);
                cmd.Parameters.AddWithValue("@seats", seats);
                cmd.Parameters.AddWithValue("@seatNumbers", seatNumbers);
                cmd.Parameters.AddWithValue("@amount", totalAmount);

                return cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(
                    "BOOKING ERROR : " + ex.Message);

                return 0;
            }
        }

        public SqlDataReader ViewBookings()
        {
            SqlConnection con = DBHelper.GetConnection();

            string query = @"
    SELECT
        B.BookingId,
        B.PNRNo,
        T.TrainName,
        T.SourceStation,
        T.DestinationStation,
        B.ClassName,
        B.PassengerCount,
        B.SeatNumbers,
        B.TotalAmount,
        B.TravelDate,
        B.BookingStatus
    FROM Bookings B
    INNER JOIN Trains T
        ON B.TrainNo = T.TrainNo";

            SqlCommand cmd = new SqlCommand(query, con);

            return cmd.ExecuteReader();
        }

        public decimal GetBookingAmount(int bookingId)
        {
            SqlConnection con =
                DBHelper.GetConnection();

            SqlCommand cmd =
                new SqlCommand(
                "SELECT TotalAmount FROM Bookings WHERE BookingId=@id",
                con);

            cmd.Parameters.AddWithValue("@id", bookingId);

            object result =
                cmd.ExecuteScalar();

            if (result == null)
                return -1;

            return Convert.ToDecimal(result);
        }
    }
}