using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GolfClub.API.Models
{
    public class TeeTime
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("Reservation")]
        public int ReservationId { get; set; }
        [StringLength(50)]
        public string Subject { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int score { get; set; }
        [StringLength(100)]
        public string RecurrenceRule { get; set; }

    }
}