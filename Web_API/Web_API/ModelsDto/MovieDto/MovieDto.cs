using System.Text.Json.Serialization;

namespace Web_API.ModelsDto.MovieDto
{
    public class MovieDto
    {
        public int MovieID { get; set; }
        public string Title { get; set; }

        public string ImgLink { get; set; }

        public string Description { get; set; }

        public int Duration { get; set; }

        public string Language { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string Censorship { get; set; }

        public string Country { get; set; }

    }
}
