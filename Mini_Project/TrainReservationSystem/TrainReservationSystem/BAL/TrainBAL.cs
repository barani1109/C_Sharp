using System;
using System.Data.SqlClient;
using TrainReservationSystem.DAL;

namespace TrainReservationSystem.BAL
{
    class TrainBAL
    {
        TrainDAL dal = new TrainDAL();

        public bool TrainExists(int trainNo)
        {
            return dal.TrainExists(trainNo);
        }

        public bool AddTrain(
            int no,
            string name,
            string source,
            string dest,
            int ac2Seats,
            int ac3Seats,
            int sleeperSeats,
            decimal ac2Fare,
            decimal ac3Fare,
            decimal sleeperFare)
        {
            return dal.AddTrain(
                no, name, source, dest,
                ac2Seats, ac3Seats, sleeperSeats,
                ac2Fare, ac3Fare, sleeperFare) > 0;
        }

        public void SearchTrain(string source, string destination)
        {
            var dr = dal.SearchTrain(source, destination);

            Console.WriteLine("\n--- SEARCH RESULT ---");

            bool found = false;

            while (dr.Read())
            {
                found = true;
                Console.WriteLine(
                    dr["TrainNo"] + " | " +
                    dr["TrainName"] + " | " +
                    dr["SourceStation"] + " -> " +
                    dr["DestinationStation"]);
            }

            if (!found)
                Console.WriteLine("No Train Available");
        }

        public decimal GetFare(int trainNo, string className)
        {
            return dal.GetFare(trainNo, className);
        }

        public void ViewTrains()
        {
            var dr = dal.ViewTrains();

            Console.WriteLine("\n--- TRAIN LIST ---");

            while (dr.Read())
            {
                Console.WriteLine(
                    "\nTrain No      : " + dr["TrainNo"] +
                    "\nTrain Name    : " + dr["TrainName"] +
                    "\nFrom          : " + dr["SourceStation"] +
                    "\nTo            : " + dr["DestinationStation"] +
                    "\n2AC Seats     : " + dr["Seats_2AC"] +
                    "\n3AC Seats     : " + dr["Seats_3AC"] +
                    "\nSleeper Seats : " + dr["Seats_Sleeper"] +
                    "\n2AC Fare      : " + dr["Charges_2AC"] +
                    "\n3AC Fare      : " + dr["Charges_3AC"] +
                    "\nSleeper Fare  : " + dr["Charges_Sleeper"]);
            }
        }

        public bool DeleteTrain(int trainNo)
        {
            if (dal.HasBookings(trainNo))
            {
                Console.WriteLine(
                    "Cannot delete train. Bookings exist for this train.");
                return false;
            }

            return dal.DeleteTrain(trainNo) > 0;
        }

        public bool UpdateTrain(
            int trainNo,
            string trainName,
            string source,
            string destination,
            int seats2AC,
            int seats3AC,
            int seatsSleeper,
            decimal fare2AC,
            decimal fare3AC,
            decimal fareSleeper)
        {
            return dal.UpdateTrain(
                trainNo, trainName, source, destination,
                seats2AC, seats3AC, seatsSleeper,
                fare2AC, fare3AC, fareSleeper) > 0;
        }
    }
}