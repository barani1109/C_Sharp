using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace TrainReservationSystem.DAL
{
     class DBHelper
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(
                "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TrainReservation;Integrated Security=True");

            con.Open();
            return con;
        }
    }
}
