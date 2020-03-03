using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GolfClub.API.Models
{
    public class ReservationType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReservationTypeID { get; set; }
        [StringLength(20)]
        public string Name { get; set; }
    }
}