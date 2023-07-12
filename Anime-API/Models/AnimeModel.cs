namespace Anime_API.Models
{
    public class AnimeModel
    {
        public int Id_AnimeModel { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<string> Genres { get; set; }
        public int Episodes { get; set; }
       
        public string Status { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public double Rating { get; set; }
        public int PopularityRank { get; set; }
        public string ImageUrl { get; set; }
        public string TrailerUrl { get; set; }
    }

}
