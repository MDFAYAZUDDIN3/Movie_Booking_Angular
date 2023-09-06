using System.Text.Json.Serialization;

namespace Web_API.ModelsDto.CinemaDto
{
    public class CinemaAddressDto
    {
        [JsonIgnore]
        public int CinemaAdressID { get; set; }

        public string ZipCode { get; set; }

        public string City { get; set; }

        public string Country { get; set; }
    }
}
