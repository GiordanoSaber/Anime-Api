namespace Anime_API.Models
{
    public class CharacterModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AnimeId { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
