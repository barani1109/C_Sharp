using System;
using TrainReservationSystem.Modules;

namespace TrainReservationSystem.Menus
{
    class MainMenu
    {
        public void ShowMainMenu()
        {
            int choice;

            do
            {
                Console.WriteLine("\n===== TRAIN RESERVATION SYSTEM =====");
                Console.WriteLine("1. Admin Login");
                Console.WriteLine("2. User Login");
                Console.WriteLine("3. Register");
                Console.WriteLine("4. Exit");

                Console.Write("Enter choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:

                        Console.WriteLine("\n--- ADMIN LOGIN ---");

                        LoginModule adminLogin =
                            new LoginModule();

                        int adminStatus =
                            adminLogin.Login();

                        if (adminStatus == 1)
                        {
                            AdminMenu admin =
                                new AdminMenu();

                            admin.ShowAdminMenu();
                        }

                        break;

                    case 2:

                        Console.WriteLine("\n--- USER LOGIN ---");

                        LoginModule userLogin =
                            new LoginModule();

                        int userStatus =
                            userLogin.Login();

                        if (userStatus == 1)
                        {
                            UserMenu user =
                                new UserMenu();

                            user.ShowUserMenu();
                        }

                        break;

                    case 3:

                        RegistrationModule reg =
                            new RegistrationModule();

                        reg.Register();

                        break;

                    case 4:

                        Console.WriteLine("Exiting System...");
                        break;

                    default:

                        Console.WriteLine("Invalid Choice");
                        break;
                }

            } while (choice != 4);
        }
    }
}