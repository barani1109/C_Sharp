using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainReservationSystem.Modules;
namespace TrainReservationSystem.Menus
{
 class UserMenu
    {
        TrainModule trainModule = new TrainModule();
        BookingModule bookingModule = new BookingModule();
        CancellationModule cancellationModule = new CancellationModule();
        public void ShowUserMenu()
        {
            int choice;

            do
            {
                Console.WriteLine("\n===== USER MENU =====");
                Console.WriteLine("1. View All Trains");
                Console.WriteLine("2. Search Trains");
                Console.WriteLine("3. Book Ticket");
                Console.WriteLine("4. Cancel Ticket");
                Console.WriteLine("5. View My Bookings");
                Console.WriteLine("6. Logout");
                Console.Write("Enter choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        trainModule.ViewTrains();
                        break;
                    case 2:
                        trainModule.SearchTrain();
                        break;

                    case 3:
                        bookingModule.BookTicket();
                        break;

                    case 4:
                       
                        cancellationModule.CancelTicket();
                        break;

                    case 5:
                      
                        bookingModule.ViewBookings();
                        break;

                    case 6:
                        Console.WriteLine("Logging out...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

            } while (choice != 6);
        }
    }
}
