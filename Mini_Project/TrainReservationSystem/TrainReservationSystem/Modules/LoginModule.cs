using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainReservationSystem.BAL;

namespace TrainReservationSystem.Modules
{
    class LoginModule
    {
        UserBAL bal = new UserBAL();

        public int Login()
        {
            Console.WriteLine("\n--- LOGIN ---");

            Console.Write("Enter Username: ");
            string user = Console.ReadLine();

            Console.Write("Enter Password: ");
            string pass = Console.ReadLine();

            bool status = bal.Login(user, pass);

            if (status)
            {
                Console.WriteLine("Login Successful");
                return 1;
            }
            else
            {
                Console.WriteLine("Invalid Credentials");
                return 0;
            }
        }

        }
}
