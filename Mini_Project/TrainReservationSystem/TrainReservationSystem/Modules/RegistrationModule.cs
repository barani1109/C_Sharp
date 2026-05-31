using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainReservationSystem.BAL;

namespace TrainReservationSystem.Modules
{
    class RegistrationModule
    {
        UserBAL bal = new UserBAL();

        public void Register()
        {
            Console.WriteLine("\n--- REGISTRATION ---");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Password: ");
            string pass = Console.ReadLine();

            Console.Write("User Type (Admin/User): ");
            string type = Console.ReadLine();

            Console.Write("Phone: ");
            string phone = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            bool result = bal.Register(name, pass, type, phone, email);

            if (result)
                Console.WriteLine("User Registered Successfully");
            else
                Console.WriteLine("Registration Failed");
        }
    }
}
