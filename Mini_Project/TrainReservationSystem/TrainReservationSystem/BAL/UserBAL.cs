using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainReservationSystem.DAL;

namespace TrainReservationSystem.BAL
{
     class UserBAL
    {
        UserDAL dal = new UserDAL();

        public bool Register(string name, string pass, string type, string phone, string email)
        {
            if (name == "" || pass == "")
            {
                Console.WriteLine("Username and Password cannot be empty");
                return false;
            }

            int result = dal.RegisterUser(name, pass, type, phone, email);

            return result > 0;
        }

        public bool Login(string username, string password)
        {
            int count = dal.Login(username, password);

            return count > 0;
        }
    }
}
