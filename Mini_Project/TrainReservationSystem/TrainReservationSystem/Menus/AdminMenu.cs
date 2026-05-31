using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainReservationSystem.Modules;


namespace TrainReservationSystem.Menus
{
  class AdminMenu
    {
        TrainModule trainModule = new TrainModule();
        BookingModule bookingModule = new BookingModule();
        CancellationModule cancellationModule = new CancellationModule();
        ReportModule reportModule = new ReportModule();
        public void ShowAdminMenu()
        {
            int choice;

            do
            {
                Console.WriteLine("\n===== ADMIN MENU =====");
                Console.WriteLine("1. Add Train");
                Console.WriteLine("2. View Trains");
                Console.WriteLine("3. Edit Train");
                Console.WriteLine("4. Delete Train");
                Console.WriteLine("5. View Bookings");
                Console.WriteLine("6. View Cancellations");
                Console.WriteLine("7. Reports");
                Console.WriteLine("8. Back To Main Menu");
                Console.Write("Enter choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        trainModule.AddTrain();
                        break;

                    case 2:
                        trainModule.ViewTrains();
                        break;
                    case 3:
                        trainModule.EditTrain();
                        break;

                    case 4:
                        trainModule.DeleteTrain();
                        break;

                    case 5:
                        bookingModule.ViewBookings();
                        break;

                    case 6:
                        cancellationModule.ViewCancellations();
                        break;

                    case 7:

                        Console.WriteLine("\n===== REPORTS =====");
                        Console.WriteLine("1. Revenue Report");
                        Console.WriteLine("2. Train Wise Bookings");

                        int reportChoice =
                            Convert.ToInt32(Console.ReadLine());

                        switch (reportChoice)
                        {
                            case 1:
                                reportModule.ShowRevenue();
                                break;

                            case 2:
                                reportModule.ShowTrainWiseBookings();
                                break;

                            default:
                                Console.WriteLine("Invalid Report Choice");
                                break;
                        }
                        break;

                    case 8:
                        Console.WriteLine("Returning to Main Menu...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

            } while (choice != 8);
        }
    }
}
