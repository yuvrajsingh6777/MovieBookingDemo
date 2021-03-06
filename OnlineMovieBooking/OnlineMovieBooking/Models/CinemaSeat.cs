using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OnlineMovieBooking.Models
{
    public class CinemaSeat
    {
        [Key]
        public int CinemaSeatId { get; set; }
        public string SeatNumber { get; set; }
        public int Type { get; set; }
        public int CinemaHallId { get; set; }

        public virtual CinemaHall CinemaHall { get; set; }
        public virtual ICollection<ShowSeat> Show_Seats { get; set; }
    }
}