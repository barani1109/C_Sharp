using System;
using TrainReservationSystem.BAL;

namespace TrainReservationSystem.Modules
{
    class BookingModule
    {
        BookingBAL bal = new BookingBAL();
        TrainModule trainModule = new TrainModule();
        TrainBAL trainBAL = new TrainBAL();

        public void BookTicket()
        {
            try
            {
                Console.WriteLine("\n--- BOOK TRAIN TICKET ---");

                Console.WriteLine("\nAVAILABLE TRAINS");
                trainModule.ViewTrains();

                Console.Write("\nEnter Train No: ");
                int trainNo = Convert.ToInt32(Console.ReadLine());

                if (!trainBAL.TrainExists(trainNo))
                {
                    Console.WriteLine(
                        "Train Number " + trainNo +
                        " does not exist.");
                    return;
                }

                Console.WriteLine("\nAVAILABLE CLASSES");
                Console.WriteLine("2AC");
                Console.WriteLine("3AC");
                Console.WriteLine("Sleeper");

                Console.Write("Enter Class Name : ");
                string className = Console.ReadLine();

                if (className != "2AC" &&
                    className != "3AC" &&
                    className != "Sleeper")
                {
                    Console.WriteLine("Invalid Class");
                    return;
                }

                decimal fare =
                    trainBAL.GetFare(
                        trainNo,
                        className);

                Console.WriteLine(
                    "\nTicket Fare Per Seat : " +
                    fare);

                Console.WriteLine("\nAVAILABLE SEATS");

                for (int i = 1; i <= 10; i++)
                {
                    if (className == "Sleeper")
                        Console.Write("S" + i + " ");
                    else if (className == "3AC")
                        Console.Write("B" + i + " ");
                    else
                        Console.Write("A" + i + " ");
                }

                Console.WriteLine();

                Console.Write(
                    "\nEnter Number Of Seats (Max 3): ");
                int seats =
                    Convert.ToInt32(Console.ReadLine());

                if (seats <= 0 || seats > 3)
                {
                    Console.WriteLine(
                        "Maximum 3 seats allowed");
                    return;
                }

                Console.Write("Enter Seat Numbers: ");
                string seatNumbers =
                    Console.ReadLine();

                Console.Write("Enter Travel Date (yyyy-mm-dd): ");

                DateTime travelDate;

                bool isValidDate = DateTime.TryParse(Console.ReadLine(), out travelDate);

                if (!isValidDate)
                {
                    Console.WriteLine("Invalid date format");
                    return;
                }

                // remove time part for safe comparison
                DateTime today = DateTime.Today;

                if (travelDate < today)
                {
                    Console.WriteLine("ERROR: Travel date cannot be in the past");
                    return;
                }

                long pnr =
                    Convert.ToInt64(
                        DateTime.Now.ToString(
                            "yyyyMMddHHmmss"));

                int userId = 1;

                decimal totalAmount =
                    fare * seats;

                bool result =
                    bal.BookTicket(
                        pnr,
                        userId,
                        trainNo,
                        className,
                        DateTime.Now,
                        travelDate,
                        seats,
                        seatNumbers,
                        totalAmount);

                if (result)
                {
                    Console.WriteLine(
                        "\n===== BOOKING SUCCESSFUL =====");

                    Console.WriteLine(
                        "PNR Number   : " + pnr);

                    Console.WriteLine(
                        "Train No     : " + trainNo);

                    Console.WriteLine(
                        "Class        : " + className);

                    Console.WriteLine(
                        "No Of Seats  : " + seats);

                    Console.WriteLine(
                        "Seat Numbers : " +
                        seatNumbers);

                    Console.WriteLine(
                        "Travel Date  : " +
                        travelDate.ToShortDateString());

                    Console.WriteLine(
                        "Fare Per Seat: " +
                        fare);

                    Console.WriteLine(
                        "Total Amount : " +
                        totalAmount);
                }
                else
                {
                    Console.WriteLine(
                        "Booking Failed");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine(
                    "Invalid Input");
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    "ERROR : " + ex.Message);
            }
        }

        public void ViewBookings()
        {
            bal.ViewBookings();
        }
    }
}