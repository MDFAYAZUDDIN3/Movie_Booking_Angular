namespace Web_API.ModelsDto.BookingDto
{
    public class Ticket
    {
        public int BookingID { get; set; }
        public int ShowID { get; set; }
        public string MovieName { get; set; }
        public string TotalPrice { get; set; }
        public DateTime TimeStamp { get; set; }
        public int NumberOfTickets { get; set; }
    }
}
