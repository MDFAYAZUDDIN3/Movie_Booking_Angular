namespace Web_API.ModelsDto.CinemaDto
{
    public class CinemaSeatDto
    {
        public int SeatNumber { get; set; }

        public int type { get; set; } //ENUM

        // Navigation Property
        public int CinemaHallID { get; set; }
    }
}
