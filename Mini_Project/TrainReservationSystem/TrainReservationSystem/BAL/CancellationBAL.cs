using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainReservationSystem.DAL;

namespace TrainReservationSystem.BAL
{
   class CancellationBAL
    {
        CancellationDAL cancelDAL = new CancellationDAL();
     

        public bool CancelTicket(int bookingId, int seats, decimal totalAmount)
        {
            if (seats <= 0)
            {
                Console.WriteLine("Invalid seats to cancel");
                return false;
            }

            // Refund logic -10% deduction
            decimal refund = totalAmount - (totalAmount * 0.10m);

            int result = cancelDAL.CancelTicket(
                bookingId, DateTime.Now, seats, refund);

            if (result > 0)
            {
                cancelDAL.UpdateBookingStatus(bookingId, "Cancelled");
                return true;
            }

            return false;
        }

        public void ViewCancellations()
        {
            var dr = cancelDAL.ViewCancellations();

            Console.WriteLine("\n--- CANCELLATIONS ---");

            while (dr.Read())
            {
                Console.WriteLine(

                     "\nCancel ID      : " + dr["CancelId"] +
                      "\nBooking ID     : " + dr["BookingId"] +
                      "\nCancelledSeats : " + dr["CancelledSeats"] +
                       "\nRefund Amount  : " + dr["RefundAmount"]);

                Console.WriteLine(
                "\n-----------------------------------");
            }
        }
        }
}
