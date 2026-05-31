using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainReservationSystem.Menus
{
    class Programs
    {

        static void Main(string[] args)
        {
            MainMenu menu = new MainMenu();
            menu.ShowMainMenu();

            Console.ReadLine();
        }
    }
}
