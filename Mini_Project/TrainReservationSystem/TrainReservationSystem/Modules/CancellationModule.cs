using System;
using TrainReservationSystem.BAL;

namespace TrainReservationSystem.Modules
{
    class CancellationModule
    {
        CancellationBAL bal = new CancellationBAL();
        BookingModule bookingModule = new BookingModule();

        public void CancelTicket()
        {
       
            try
            {
                Console.WriteLine("\n===== CANCEL TICKET =====");

                Console.WriteLine("\nYOUR BOOKINGS:");
                bookingModule.ViewBookings();

                Console.Write("\nEnter Booking ID to Cancel: ");
                int bookingId =
                    Convert.ToInt32(Console.ReadLine());

                if (bookingId <= 0)
                {
                    Console.WriteLine("Invalid Booking ID");
                    return;
                }

                Console.Write("Enter Number of Seats to Cancel: ");
                int seats =
                    Convert.ToInt32(Console.ReadLine());

                if (seats <= 0)
                {
                    Console.WriteLine("Invalid Seat Count");
                    return;
                }

                // Get amount from DB
                BookingBAL bookingBAL = new BookingBAL();

                decimal amount =
                    bookingBAL.GetBookingAmount(bookingId);

                if (amount == -1)
                {
                    Console.WriteLine("Booking ID not found");
                    return;
                }

                Console.WriteLine(
                    "\nBooking Amount : " + amount);

                bool result =
                    bal.CancelTicket(
                        bookingId,
                        seats,
                        amount);

                if (result)
                {
                    Console.WriteLine(
                        "\nCancellation Successful");
                }
                else
                {
                    Console.WriteLine(
                        "\nCancellation Failed");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine(
                    "Invalid Input. Enter numeric values only.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    "ERROR : " + ex.Message);
            }
        }
        

        public void ViewCancellations()
        {
            bal.ViewCancellations();
        }
    }
}