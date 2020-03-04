using System;

namespace GolfClub.API.DTOs
{
    public class reservationDTO
    {
        public int id { get; set; }
        public string subject { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public int reservationType { get; set; }
        public string recurringData { get; set; }
        public int noOfPlayer { get; set; }
        public int approval { get; set; }

    }
}