using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainReservationSystem.DAL
{
     class CancellationDAL
    {
         
        public int CancelTicket(int bookingId, DateTime date, int seats, decimal refund)
        {
            SqlConnection con = DBHelper.GetConnection();

            SqlCommand cmd = new SqlCommand(
                "INSERT INTO Cancellations VALUES(@b,@d,@s,@r)", con);

            cmd.Parameters.AddWithValue("@b", bookingId);
            cmd.Parameters.AddWithValue("@d", date);
            cmd.Parameters.AddWithValue("@s", seats);
            cmd.Parameters.AddWithValue("@r", refund);

            return cmd.ExecuteNonQuery();
        }

        public SqlDataReader ViewCancellations()
        {
            SqlConnection con = DBHelper.GetConnection();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Cancellations", con);

            return cmd.ExecuteReader();
        }
        public void UpdateBookingStatus(int bookingId, string status)
        {
            SqlConnection con = DBHelper.GetConnection();

            SqlCommand cmd = new SqlCommand(
                "UPDATE Bookings SET BookingStatus=@status WHERE BookingId=@id",
                con);

            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@id", bookingId);

            cmd.ExecuteNonQuery();
        }
    }
}
