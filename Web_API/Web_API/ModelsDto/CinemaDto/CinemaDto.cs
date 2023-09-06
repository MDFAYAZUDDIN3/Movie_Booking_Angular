using System.Text.Json.Serialization;

namespace Web_API.ModelsDto.CinemaDto
{
    public class CinemaDto
    {
        [JsonIgnore]
        public int CinemaID { get; set; }
        public string Name { get; set; }
        public int TotalCinemaHalls { get; set; }
        public CinemaAddressDto CinemaAddress { get; set; }
    }
}
