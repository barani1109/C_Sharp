using System;
using System.Data.SqlClient;

namespace TrainReservationSystem.DAL
{
    class TrainDAL
    {
        public int AddTrain(
            int no,
            string name,
            string source,
            string dest,
            int ac2Seats,
            int ac3Seats,
            int sleeperSeats,
            decimal ac2Fare,
            decimal ac3Fare,
            decimal sleeperFare)
        {
            SqlConnection con = DBHelper.GetConnection();

            SqlCommand cmd = new SqlCommand(
                @"INSERT INTO Trains
                VALUES
                (
                    @no,@name,@src,@dest,
                    @a2,@a3,@sl,
                    @f2,@f3,@fs,
                    0
                )", con);

            cmd.Parameters.AddWithValue("@no", no);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@src", source);
            cmd.Parameters.AddWithValue("@dest", dest);

            cmd.Parameters.AddWithValue("@a2", ac2Seats);
            cmd.Parameters.AddWithValue("@a3", ac3Seats);
            cmd.Parameters.AddWithValue("@sl", sleeperSeats);

            cmd.Parameters.AddWithValue("@f2", ac2Fare);
            cmd.Parameters.AddWithValue("@f3", ac3Fare);
            cmd.Parameters.AddWithValue("@fs", sleeperFare);

            return cmd.ExecuteNonQuery();
        }

        public SqlDataReader ViewTrains()
        {
            SqlConnection con = DBHelper.GetConnection();

            SqlCommand cmd = new SqlCommand(
                "SELECT * FROM Trains WHERE IsDeleted=0", con);

            return cmd.ExecuteReader();
        }

        public bool TrainExists(int trainNo)
        {
            SqlConnection con = DBHelper.GetConnection();

            SqlCommand cmd = new SqlCommand(
                @"SELECT COUNT(*) 
                  FROM Trains 
                  WHERE TrainNo=@tno AND IsDeleted=0", con);

            cmd.Parameters.AddWithValue("@tno", trainNo);

            return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
        }

        public SqlDataReader SearchTrain(string source, string destination)
        {
            SqlConnection con = DBHelper.GetConnection();

            SqlCommand cmd = new SqlCommand(
                @"SELECT * 
                  FROM Trains 
                  WHERE SourceStation=@s 
                  AND DestinationStation=@d
                  AND IsDeleted=0", con);

            cmd.Parameters.AddWithValue("@s", source);
            cmd.Parameters.AddWithValue("@d", destination);

            return cmd.ExecuteReader();
        }

        public decimal GetFare(int trainNo, string className)
        {
            SqlConnection con = DBHelper.GetConnection();

            SqlCommand cmd = new SqlCommand(
                @"SELECT 
                    CASE 
                        WHEN @class='2AC' THEN Charges_2AC
                        WHEN @class='3AC' THEN Charges_3AC
                        WHEN @class='Sleeper' THEN Charges_Sleeper
                    END
                  FROM Trains
                  WHERE TrainNo=@tno", con);

            cmd.Parameters.AddWithValue("@tno", trainNo);
            cmd.Parameters.AddWithValue("@class", className);

            return Convert.ToDecimal(cmd.ExecuteScalar());
        }

        // CHECK BOOKINGS EXIST
        public bool HasBookings(int trainNo)
        {
            SqlConnection con = DBHelper.GetConnection();

            SqlCommand cmd = new SqlCommand(
                @"SELECT COUNT(*) 
                  FROM Bookings 
                  WHERE TrainNo=@tno 
                  AND BookingStatus='Booked'", con);

            cmd.Parameters.AddWithValue("@tno", trainNo);

            return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
        }

        // SOFT DELETE
        public int DeleteTrain(int trainNo)
        {
            SqlConnection con = DBHelper.GetConnection();

            SqlCommand cmd = new SqlCommand(
                "UPDATE Trains SET IsDeleted=1 WHERE TrainNo=@no", con);

            cmd.Parameters.AddWithValue("@no", trainNo);

            return cmd.ExecuteNonQuery();
        }

        public int UpdateTrain(
            int trainNo,
            string trainName,
            string source,
            string destination,
            int seats2AC,
            int seats3AC,
            int seatsSleeper,
            decimal fare2AC,
            decimal fare3AC,
            decimal fareSleeper)
        {
            SqlConnection con = DBHelper.GetConnection();

            SqlCommand cmd = new SqlCommand(
                @"UPDATE Trains
                  SET TrainName=@name,
                      SourceStation=@source,
                      DestinationStation=@dest,
                      Seats_2AC=@s2,
                      Seats_3AC=@s3,
                      Seats_Sleeper=@ss,
                      Charges_2AC=@f2,
                      Charges_3AC=@f3,
                      Charges_Sleeper=@fs
                  WHERE TrainNo=@no", con);

            cmd.Parameters.AddWithValue("@no", trainNo);
            cmd.Parameters.AddWithValue("@name", trainName);
            cmd.Parameters.AddWithValue("@source", source);
            cmd.Parameters.AddWithValue("@dest", destination);

            cmd.Parameters.AddWithValue("@s2", seats2AC);
            cmd.Parameters.AddWithValue("@s3", seats3AC);
            cmd.Parameters.AddWithValue("@ss", seatsSleeper);

            cmd.Parameters.AddWithValue("@f2", fare2AC);
            cmd.Parameters.AddWithValue("@f3", fare3AC);
            cmd.Parameters.AddWithValue("@fs", fareSleeper);

            return cmd.ExecuteNonQuery();
        }
    }
}