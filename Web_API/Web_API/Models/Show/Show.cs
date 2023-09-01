﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Web_API.Models.Bookings;
using Web_API.Models.Cinema;

namespace Web_API.Models.Show
{
    public class Show
    {
        [Key] // DataAnnotations used to declare that it is a primary key.
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Creating a Auto incremented ID - sql example(Identity(1,1))
        [Column(TypeName = "int")]
        [Required]
        public int ShowID { get; set; }

        [Column(TypeName = "datetime")]
        [Required]
        public DateTime Date { get; set; }

        [Column(TypeName = "datetime")]
        [Required]
        public DateTime StartTime { get; set; }

        [Column(TypeName = "datetime")]
        [Required]
        public DateTime EndTime { get; set; }

        //Navigartion Properties

        public ICollection<Booking> Booking { get; set; }
        public ICollection<ShowSeat> ShowSeats { get; set; }

        public int MovieID { get; set; }
        public Movie.Movie Movie { get; set; }

        public int CinemaHallID { get; set; }
        public CinemaHall CinemaHall { get; set; }
    }
}
