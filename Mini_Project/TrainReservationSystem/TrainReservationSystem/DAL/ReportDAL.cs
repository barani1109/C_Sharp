using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainReservationSystem.DAL
{
     class ReportDAL
    {
        public SqlDataReader GetRevenue()
        {
            SqlConnection con = DBHelper.GetConnection();

            SqlCommand cmd = new SqlCommand(
                "SELECT SUM(TotalAmount) FROM Bookings WHERE BookingStatus='Booked'", con);

            return cmd.ExecuteReader();
        }

        public SqlDataReader TrainWiseBookings()
        {
            SqlConnection con = DBHelper.GetConnection();

            SqlCommand cmd = new SqlCommand(
                "SELECT TrainNo, COUNT(*) AS Total FROM Bookings GROUP BY TrainNo", con);

            return cmd.ExecuteReader();
        }
    }
}
