using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainReservationSystem.BAL;
using TrainReservationSystem.DAL;

namespace TrainReservationSystem.Modules
{ 
   class TrainModule
    {
    TrainBAL bal = new TrainBAL();

        public void AddTrain()
        {
            Console.WriteLine("\n===== ADD TRAIN =====");

            Console.Write("Train No: ");
            int no =
                Convert.ToInt32(Console.ReadLine());

            Console.Write("Train Name: ");
            string name =
                Console.ReadLine();

            Console.Write("From: ");
            string source =
                Console.ReadLine();

            Console.Write("To: ");
            string dest =
                Console.ReadLine();

            Console.Write("\n2AC Seats: ");
            int ac2Seats =
                Convert.ToInt32(Console.ReadLine());

            Console.Write("3AC Seats: ");
            int ac3Seats =
                Convert.ToInt32(Console.ReadLine());

            Console.Write("Sleeper Seats: ");
            int sleeperSeats =
                Convert.ToInt32(Console.ReadLine());

            Console.Write("2AC Charge: ");
            decimal ac2Fare =
                Convert.ToDecimal(Console.ReadLine());

            Console.Write("3AC Charge: ");
            decimal ac3Fare =
                Convert.ToDecimal(Console.ReadLine());

            Console.Write("Sleeper Charge: ");
            decimal sleeperFare =
                Convert.ToDecimal(Console.ReadLine());

            bool result =
                bal.AddTrain(
                    no,
                    name,
                    source,
                    dest,
                    ac2Seats,
                    ac3Seats,
                    sleeperSeats,
                    ac2Fare,
                    ac3Fare,
                    sleeperFare);

            if (result)
            {
                Console.WriteLine(
                    "\nTrain Added Successfully");
            }
            else
            {
                Console.WriteLine(
                    "\nFailed To Add Train");
            }
        }


        public void ViewTrains()
    {
        bal.ViewTrains();
    }
        public void SearchTrain()
        {
            Console.WriteLine("\n===== SEARCH TRAIN =====");

            Console.Write("Enter Source Station : ");
            string source =
                Console.ReadLine();

            Console.Write("Enter Destination Station : ");
            string destination =
                Console.ReadLine();

            TrainBAL bal =
                new TrainBAL();

            bal.SearchTrain(
                source,
                destination);
        }
        public void EditTrain()
        {
            Console.WriteLine("\n===== EDIT TRAIN =====");

            Console.Write("Train No : ");
            int trainNo =
                Convert.ToInt32(Console.ReadLine());

            Console.Write("Train Name : ");
            string name =
                Console.ReadLine();

            Console.Write("Source : ");
            string source =
                Console.ReadLine();

            Console.Write("Destination : ");
            string destination =
                Console.ReadLine();

            Console.Write("2AC Seats : ");
            int ac2Seats =
                Convert.ToInt32(Console.ReadLine());

            Console.Write("3AC Seats : ");
            int ac3Seats =
                Convert.ToInt32(Console.ReadLine());

            Console.Write("Sleeper Seats : ");
            int sleeperSeats =
                Convert.ToInt32(Console.ReadLine());

            Console.Write("2AC Fare : ");
            decimal ac2Fare =
                Convert.ToDecimal(Console.ReadLine());

            Console.Write("3AC Fare : ");
            decimal ac3Fare =
                Convert.ToDecimal(Console.ReadLine());

            Console.Write("Sleeper Fare : ");
            decimal sleeperFare =
                Convert.ToDecimal(Console.ReadLine());

            bool result =
                bal.UpdateTrain(
                    trainNo,
                    name,
                    source,
                    destination,
                    ac2Seats,
                    ac3Seats,
                    sleeperSeats,
                    ac2Fare,
                    ac3Fare,
                    sleeperFare);

            Console.WriteLine(
                result ?
                "Train Updated Successfully" :
                "Update Failed");
        }

        public void DeleteTrain()
        {
            Console.WriteLine("\n===== DELETE TRAIN =====");

            Console.Write("Enter Train No : ");
            int trainNo =
                Convert.ToInt32(Console.ReadLine());

            bool result =
                bal.DeleteTrain(trainNo);

            Console.WriteLine(
                result ?
                "Train Deleted Successfully" :
                "Delete Failed");
        }
    }
}
