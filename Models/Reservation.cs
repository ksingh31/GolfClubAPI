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
        public int ReservationId { get; set; }
        [ForeignKey("User")]
        public int UserID { get; set; }
        [ForeignKey("ReservationType")]
        public int ReservationTypeID { get; set; }
        public int NumberOfPlayers { get; set; } = 4;
        // 1 means approved
        public int approved { get; set; } = 1;
        public string Subject { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int score { get; set; }
        [StringLength(100)]
        public string RecurrenceRule { get; set; }
        public List<TeeTime> teeTimes { get; set; }

    }
}