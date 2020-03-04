using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GolfClub.API.Models
{
    public class Reservation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [ForeignKey("User")]
        public int UserID { get; set; }
        [ForeignKey("ReservationType")]
        public int ReservationTypeID { get; set; }
        public int noOfPlayers { get; set; } = 4;
        // 1 means approved
        public int approval { get; set; } = 1;
        public string subject { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public int score { get; set; }
        [StringLength(100)]
        public string recurringData { get; set; }
        public List<TeeTime> teeTimes { get; set; }
    }
}