namespace Anime_API.Models
{
    public class ReviewModel
    {
        public int Id_ReviewModel { get; set; }
        public int AnimeId  { get; set; }
        public int UserId { get; set; }
        public double Rating { get; set; }
        public string Comment { get; set; }
    }
}
