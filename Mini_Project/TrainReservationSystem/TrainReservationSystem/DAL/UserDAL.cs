using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TrainReservationSystem.DAL
{
    class UserDAL
    {
        public int RegisterUser(string name, string password, string type, string phone, string email)
        {
            SqlConnection con = DBHelper.GetConnection();

            SqlCommand cmd = new SqlCommand(
                "INSERT INTO Users VALUES(@name,@pass,@type,@phone,@mail)", con);

            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@pass", password);
            cmd.Parameters.AddWithValue("@type", type);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@mail", email);

            return cmd.ExecuteNonQuery();
        }

        public int Login(string username, string password)
        {
            SqlConnection con = DBHelper.GetConnection();

            SqlCommand cmd = new SqlCommand(
                "SELECT COUNT(*) FROM Users WHERE UserName=@u AND Password=@p", con);

            cmd.Parameters.AddWithValue("@u", username);
            cmd.Parameters.AddWithValue("@p", password);

            return (int)cmd.ExecuteScalar();
        }
    }
}

