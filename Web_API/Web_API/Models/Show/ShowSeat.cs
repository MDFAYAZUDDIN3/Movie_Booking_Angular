﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Web_API.Models.Show
{
    public class ShowSeat
    {
        [Key] // DataAnnotations used to declare that it is a primary key.
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Creating a Auto incremented ID - sql example(Identity(1,1))
        [Column(TypeName = "int")]
        [Required]
        public int ShowSeatID { get; set; }

        [Column(TypeName = "int")]
        [Required]
        public int Status { get; set; }

        [Column(TypeName = "decimal")]
        [Required]
        public decimal Price { get; set; }


        // Navigation Properties
        public int ShowID { get; set; }
        public Show Show { get; set; }

        public int CinemaSeatID { get; set; }
        public Cinema.CinemaSeat CinemaSeat { get; set; }

        public int? BookingID { get; set; }
        public Bookings.Booking Booking { get; set; }

    }
}
