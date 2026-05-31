using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainReservationSystem.Models
{
    public class Cancellation
    {
        public int CancelId { get; set; }

        public int BookingId { get; set; }

        public DateTime CancelDate { get; set; }


        public int CancelledSeats { get; set; }

        public decimal RefundAmount { get; set; }
    }
}
