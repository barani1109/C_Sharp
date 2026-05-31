namespace TrainReservationSystem.Models
{
    public class Train
    {
        public int TrainNo { get; set; }

        public string TrainName { get; set; }

        public string SourceStation { get; set; }

        public string DestinationStation { get; set; }

        public int Seats_2AC { get; set; }

        public int Seats_3AC { get; set; }

        public int Seats_Sleeper { get; set; }

        public decimal Charges_2AC { get; set; }

        public decimal Charges_3AC { get; set; }

        public decimal Charges_Sleeper { get; set; }

        public bool IsDeleted { get; set; }
    }
}