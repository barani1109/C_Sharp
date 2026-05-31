using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainReservationSystem.DAL;

namespace TrainReservationSystem.Modules
{
   class ReportModule
    {
        ReportDAL dal = new ReportDAL();

        public void ShowRevenue()
        {
            Console.WriteLine("\n--- REVENUE REPORT ---");

            var dr = dal.GetRevenue();

            while (dr.Read())
            {
                Console.WriteLine("Total Revenue: " + dr[0]);
            }
        }

        public void ShowTrainWiseBookings()
        {
            Console.WriteLine("\n--- TRAIN WISE BOOKINGS ---");

            var dr = dal.TrainWiseBookings();

            while (dr.Read())
            {
                Console.WriteLine(
                    "Train No: " + dr["TrainNo"] +
                    " | Bookings: " + dr["Total"]);
            }
        }
    }
}
